using System.Threading;
using System.IO;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using WebDav.NextGen.Exceptions;

namespace WebDav.NextGen
{
    public class WebDav
    {
        private HttpClient _client;

        public WebDav()
        {
            _client = new HttpClient();
        }

        public WebDav(HttpClient client)
        {
            _client = client;
        }

        public async Task CreateDirectoryAsync(Uri path, CancellationToken token = default)
        {
            var method = new HttpMethod("MKCOL");
            var req = new HttpRequestMessage(method, path);

            var resp = await _client.SendAsync(req, token);

            ThrowOnForbidden(resp);

            if (!resp.IsSuccessStatusCode)
            {
                switch (resp.StatusCode)
                {
                    case HttpStatusCode.MethodNotAllowed:
                        throw new AlreadyExists(resp.RequestMessage?.RequestUri?.ToString());
                    case HttpStatusCode.Conflict:
                        throw new DoesNotExists(resp.RequestMessage?.RequestUri?.ToString());
                    case HttpStatusCode.InsufficientStorage:
                        throw new InsufficientSpace(resp.RequestMessage?.RequestUri?.ToString());
                    default:
                        throw new WebDavException(resp.Content == null ? "" : await resp.Content.ReadAsStringAsync(), resp.StatusCode);
                }
            }
        }

        public Task<string> GetStringAsync(Uri path, CancellationToken token = default)
        {
            throw new NotImplementedException();
        }

        public Task<byte[]> GetBytesAsync(Uri path, CancellationToken token = default)
        {
            throw new NotImplementedException();
        }

        public Task<Stream> GetStreamAsync(Uri path, CancellationToken token = default)
        {
            throw new NotImplementedException();
        }

        public Task WriteFileAsync(Uri path, byte[] data, CancellationToken token = default)
        {
            return WriteFileInternal(path, new ByteArrayContent(data), token);
        }

        public async Task WriteFileAsync(Uri path, Stream stream, bool takeOwnership = false, CancellationToken token = default)
        {
            await WriteFileInternal(path, new StreamContent(stream), token);

            if (takeOwnership)
            {
                await stream.DisposeAsync();
            }
        }

        public Task DeleteFileAsync(Uri path, CancellationToken token = default)
        {
            throw new NotImplementedException();
        }

        private static void ThrowOnForbidden(HttpResponseMessage resp)
        {
            if (!resp.IsSuccessStatusCode)
            {
                switch (resp.StatusCode)
                {
                    case HttpStatusCode.Forbidden:
                    case HttpStatusCode.Unauthorized:
                        throw new AccessDenied(resp.RequestMessage?.RequestUri?.ToString());
                    default:
                        return;
                }
            }
        }

        private async Task WriteFileInternal(Uri path, HttpContent content, CancellationToken token = default)
        {
            var req = new HttpRequestMessage(HttpMethod.Put, path)
            {
                Content = content
            };

            var resp = await _client.SendAsync(req, token);

            if (!resp.IsSuccessStatusCode)
            {
                switch (resp.StatusCode)
                {
                    case HttpStatusCode.Conflict:
                        throw new DoesNotExists(resp.RequestMessage?.RequestUri?.ToString());
                    default:
                        throw new WebDavException(resp.Content == null ? "" : await resp.Content.ReadAsStringAsync(), resp.StatusCode);
                }
            }
        }
    }
}