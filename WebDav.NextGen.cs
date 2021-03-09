using System.Threading;
using System.IO;
using System;
using System.Threading.Tasks;

public class WebDav
{
    public Task CreateDirectoryAsync(Uri path, CancellationToken token = default)
    {
        throw new NotImplementedException();
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

    public Task AddFileAsync(Uri path, byte[] data, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }

    public Task AddFileAsync(Uri path, Stream stream, bool ownStream = false, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }

    public Task DeleteFileAsync(Uri path, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }
}