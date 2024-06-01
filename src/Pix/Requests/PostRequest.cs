using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace PixDotNet.Requests
{
    internal class PostRequest<TIn, TOut> : RequestBase
    {
        public PostRequest(HttpClient client, string url, TIn body) : base(client, url, body)
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
            return await Client.SendAsync(new HttpRequestMessage(HttpMethod.Post, Endpoint)
            {
                Content = SerializeBody()
            }, cancellationToken);
        }
    }
}
