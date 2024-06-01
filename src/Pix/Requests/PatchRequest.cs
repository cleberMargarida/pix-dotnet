using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace PixDotNet.Requests
{
    internal class PatchRequest<TIn> : RequestBase
    {
        public PatchRequest(HttpClient client, string url, TIn body) : base(client, url, body)
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
            return await Client.SendAsync(new HttpRequestMessage(HttpMethod.Patch, Endpoint)
            {
                Content = SerializeBody()
            }, cancellationToken);
        }

        private HttpContent? SerializeBody()
        {
            if (Body is null)
            {
                return null;
            }

            if (Body is byte[] bodyBytes)
            {
                return new ByteArrayContent(bodyBytes);
            }

            return new ByteArrayContent(Serialize(Body));
        }
    }

    internal class PatchRequest<TIn, TOut> : RequestBase
    {
        public PatchRequest(HttpClient client, string url, TIn body) : base(client, url, body)
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
            return await Client.SendAsync(new HttpRequestMessage(HttpMethod.Patch, Endpoint)
            {
                Content = SerializeBody()
            }, cancellationToken);
        }

        private HttpContent? SerializeBody()
        {
            if (Body is null)
            {
                return null;
            }

            if (Body is byte[] bodyBytes)
            {
                return new ByteArrayContent(bodyBytes);
            }

            return new ByteArrayContent(Serialize(Body));
        }
    }
}
