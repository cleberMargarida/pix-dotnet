using PixDotNet.Models.WebHooks;
using System.Threading;
using System.Threading.Tasks;

/// <summary>
/// Interface para operações relacionadas a webhooks no sistema Pix.
/// </summary>
public interface IWebhook
{
    /// <summary>
    /// Configura um webhook de forma assíncrona.
    /// </summary>
    /// <param name="body">O corpo da configuração do webhook.</param>
    /// <param name="cancellationToken">O token de cancelamento da operação.</param>
    /// <returns>Uma tarefa que representa a operação assíncrona.</returns>
    Task ConfigureWebhookAsync(WebhookPayload body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Obtém um webhook de forma assíncrona.
    /// </summary>
    /// <param name="chave">A chave do webhook.</param>
    /// <param name="cancellationToken">O token de cancelamento da operação.</param>
    /// <returns>Uma tarefa que representa a operação assíncrona. O resultado é o webhook obtido.</returns>
    Task<Webhook> GetWebhookAsync(string chave, CancellationToken cancellationToken = default);

    /// <summary>
    /// Cancela um webhook de forma assíncrona.
    /// </summary>
    /// <param name="chave">A chave do webhook.</param>
    /// <param name="cancellationToken">O token de cancelamento da operação.</param>
    /// <returns>Uma tarefa que representa a operação assíncrona.</returns>
    Task CancelWebhookAsync(string chave, CancellationToken cancellationToken = default);

    /// <summary>
    /// Lista webhooks de forma assíncrona.
    /// </summary>
    /// <param name="params">Os parâmetros da consulta.</param>
    /// <param name="cancellationToken">O token de cancelamento da operação.</param>
    /// <returns>Uma tarefa que representa a operação assíncrona. O resultado são os webhooks consultados.</returns>
    Task<WebhooksConsultados> ListWebhooksAsync(ParametrosConsultaWebhooks @params, CancellationToken cancellationToken = default);
}

