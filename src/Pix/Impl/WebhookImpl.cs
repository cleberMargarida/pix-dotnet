using PixDotNet.Models.WebHooks;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace PixDotNet.Impl
{
    internal class WebhookImpl : PixBase, IWebhook
    {
        public WebhookImpl(HttpClient httpClient) : base(httpClient)
        {
        }

        public Task CancelWebhookAsync(string chave, CancellationToken cancellationToken = default)
        {
            return Delete("/webhook/{0}", chave).ExecuteAsync(cancellationToken);
        }

        public Task ConfigureWebhookAsync(string chave, CancellationToken cancellationToken = default)
        {
            return Put<WebhookPayload>("/webhook/{0}", chave).ExecuteAsync(cancellationToken);
        }

        public Task<Webhook> GetWebhookAsync(string chave, CancellationToken cancellationToken = default)
        {
            return Get<Webhook>("/webhook/{0}", chave).ExecuteAsync(cancellationToken);
        }

        public Task<WebhooksConsultados> ListWebhooksAsync(ParametrosConsultaWebhooks @params, CancellationToken cancellationToken = default)
        {
            return Get<WebhooksConsultados>("/webhook?", @params.ToQueryString()).ExecuteAsync(cancellationToken);
        }
    }
}
