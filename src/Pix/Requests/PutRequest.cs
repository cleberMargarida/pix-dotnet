using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace PixDotNet.Requests
{
    internal class PutRequest<TIn> : RequestBase
    {
        public PutRequest(HttpClient client, string url, TIn body) : base(client, url, body)
        {
        }

        internal async Task ExecuteAsync(CancellationToken cancellationToken)
        {
            using (var response = await SendMessageAsync(cancellationToken))
            {
                await HandleResponseAsync(response);
            }
        }

        private async Task<HttpResponseMessage> SendMessageAsync(CancellationToken cancellationToken)
        {
            return await Client.SendAsync(new HttpRequestMessage(HttpMethod.Put, Endpoint)
            {
                Content = SerializeBody()
            }, cancellationToken);
        }
    }

    internal class PutRequestOuter<TOut> : RequestBase
    {
        public PutRequestOuter(HttpClient client, string url) : base(client, url)
        {
        }

        internal async Task ExecuteAsync(CancellationToken cancellationToken)
        {
            using (var response = await SendMessageAsync(cancellationToken))
            {
                await HandleResponseAsync(response);
            }
        }

        private async Task<HttpResponseMessage> SendMessageAsync(CancellationToken cancellationToken)
        {
            return await Client.SendAsync(new HttpRequestMessage(HttpMethod.Put, Endpoint)
            {
                Content = SerializeBody()
            }, cancellationToken);
        }
    }

    internal class PutRequest<TIn, TOut> : RequestBase
    {
        public PutRequest(HttpClient client, string url, TIn body) : base(client, url, body)
        {
        }

        internal async Task<TOut> ExecuteAsync(CancellationToken cancellationToken)
        {
            using (var response = await SendMessageAsync(cancellationToken))
            {
                return await HandleResponseAsync<TOut>(response);
            }
        }

        private async Task<HttpResponseMessage> SendMessageAsync(CancellationToken cancellationToken)
        {
            return await Client.SendAsync(new HttpRequestMessage(HttpMethod.Put, Endpoint)
            {
                Content = SerializeBody()
            }, cancellationToken);
        }
    }
}
