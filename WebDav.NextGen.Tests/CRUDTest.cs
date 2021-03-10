using System;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Moq;
using Moq.Language.Flow;
using Moq.Protected;
using WebDav.NextGen.Exceptions;
using Xunit;

namespace WebDav.NextGen.Tests
{
    public class CrudTest
    {
        static ISetup<HttpMessageHandler, Task<HttpResponseMessage>> SetupSendAsync(Mock<HttpMessageHandler> mock)
        {
            return mock
                .Protected()
                .Setup<Task<HttpResponseMessage>>("SendAsync",
                    ItExpr.IsAny<HttpRequestMessage>(),
                    ItExpr.IsAny<CancellationToken>());
        }

        static void VerifySendAsync(Mock<HttpMessageHandler> mock, Times times, Expression<Func<HttpRequestMessage, bool>> pred)
        {
            try
            {
                mock.Protected().Verify("SendAsync", times, ItExpr.Is(pred), ItExpr.IsAny<CancellationToken>());
            }
            catch (MockException)
            {
                mock.Protected().Verify("Send", times, ItExpr.Is(pred), ItExpr.IsAny<CancellationToken>());
            }
        }

        static void VerifySendAsync(Mock<HttpMessageHandler> mock, Expression<Func<HttpRequestMessage, bool>> pred)
        {
            VerifySendAsync(mock, Times.AtLeast(1), pred);
        }

        [Fact]
        public async Task CreateDirectorySuccessTest()
        {
            var response = new HttpResponseMessage(HttpStatusCode.Created);

            var hMock = new Mock<HttpMessageHandler>(MockBehavior.Strict);
            SetupSendAsync(hMock).ReturnsAsync(response).Verifiable();

            var wd = new WebDav(new HttpClient(hMock.Object));
            await wd.CreateDirectoryAsync(new Uri("https://foo.bar/baz"));

            VerifySendAsync(hMock, req =>
                req.Method == new HttpMethod("MKCOL") && req.RequestUri.ToString() == "https://foo.bar/baz");
        }

        [Theory]
        [InlineData(HttpStatusCode.Unauthorized, typeof(AccessDenied))]
        [InlineData(HttpStatusCode.Forbidden, typeof(AccessDenied))]
        [InlineData(HttpStatusCode.Conflict, typeof(DoesNotExists))]
        [InlineData(HttpStatusCode.InsufficientStorage, typeof(InsufficientSpace))]
        public async Task CreateDirectoryThrowsSpecific(HttpStatusCode code, Type exceptionType)
        {
            var response = new HttpResponseMessage(code);

            var hMock = new Mock<HttpMessageHandler>(MockBehavior.Strict);
            SetupSendAsync(hMock).ReturnsAsync(response).Verifiable();

            var wd = new WebDav(new HttpClient(hMock.Object));
            await Assert.ThrowsAsync(exceptionType, () => wd.CreateDirectoryAsync(new Uri("https://foo.bar/baz")));
        }

        [Fact]
        public async Task CreateDirectoryThrowsOnFailure()
        {
            foreach (var code in Enum.GetValues<HttpStatusCode>().Where(c => (int)c >= 400))
            {
                var response = new HttpResponseMessage(code);

                var hMock = new Mock<HttpMessageHandler>(MockBehavior.Strict);
                SetupSendAsync(hMock).ReturnsAsync(response).Verifiable();

                var wd = new WebDav(new HttpClient(hMock.Object));

                var ex = await Record.ExceptionAsync(() => wd.CreateDirectoryAsync(new Uri("https://foo.bar/baz")));
                Assert.IsAssignableFrom<WebDavException>(ex);
            }
        }
    }
}