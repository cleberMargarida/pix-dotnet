using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace PixDotNet.Requests
{
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
            return await Client.SendAsync(new HttpRequestMessage(HttpMethod.Get, Endpoint)
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
