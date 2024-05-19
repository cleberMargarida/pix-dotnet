using PixDotNet.Models.WebHooks;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace PixDotNet.Impl
{
    internal class WebhookImpl : IWebhook
    {
        private readonly HttpClient _httpClient;

        public WebhookImpl(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        /// <inheritdoc/>
        public Task CancelWebhookAsync(string chave, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public Task ConfigureWebhookAsync(WebhookPayload body, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<Webhook> GetWebhookAsync(string chave, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<WebhooksConsultados> ListWebhooksAsync(ParametrosConsultaWebhooks @params, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }
    }
}