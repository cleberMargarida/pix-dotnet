using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace PixDotNet.Requests
{
    internal class DeleteRequest : RequestBase
    {
        public DeleteRequest(HttpClient client, string url) : base(client, url)
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
            return await Client.SendAsync(new HttpRequestMessage(HttpMethod.Delete, Endpoint), cancellationToken);
        }
    }
}
