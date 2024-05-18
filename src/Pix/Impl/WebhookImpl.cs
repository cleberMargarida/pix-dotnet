using PixDotNet.Models.WebHooks;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace PixDotNet.Impl
{
    internal class WebhookImpl : IWebhook
    {
        private HttpClient httpClient;

        public WebhookImpl(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        /// <inheritdoc/>
        public void CancelWebhook(string chave)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public Task CancelWebhookAsync(string chave, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public void ConfigureWebhook(WebhookPayload body)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public Task ConfigureWebhookAsync(WebhookPayload body, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public Webhook GetWebhook(string chave)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<Webhook> GetWebhookAsync(string chave, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public WebhooksConsultados ListWebhooks(ParametrosConsultaWebhooks @params)
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