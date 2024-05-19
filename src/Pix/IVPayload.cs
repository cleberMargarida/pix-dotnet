using PixDotNet.Models.CobV;
using System;
using System.Threading;
using System.Threading.Tasks;

/// <summary>
/// Interface para operações relacionadas aos payloads de cobranças com vencimento (CobV) no sistema Pix.
/// </summary>
public interface IVPayload
{
    /// <summary>
    /// Obtém o payload de uma cobrança com vencimento de forma assíncrona.
    /// </summary>
    /// <param name="pixUrlAccessToken">O token de acesso da URL PIX.</param>
    /// <param name="cancellationToken">O token de cancelamento opcional.</param>
    /// <returns>Uma tarefa que representa a operação assíncrona. O resultado é o payload da cobrança com vencimento.</returns>
    Task<CobVPayload> GetCobVPayloadAsync(string pixUrlAccessToken, CancellationToken cancellationToken = default);

    /// <summary>
    /// Obtém o payload de uma cobrança com vencimento de forma assíncrona.
    /// </summary>
    /// <param name="pixUrlAccessToken">O token de acesso da URL PIX.</param>
    /// <param name="codMunicipio">O código do município.</param>
    /// <param name="cancellationToken">O token de cancelamento opcional.</param>
    /// <returns>Uma tarefa que representa a operação assíncrona. O resultado é o payload da cobrança com vencimento.</returns>
    Task<CobVPayload> GetCobVPayloadAsync(string pixUrlAccessToken, string codMunicipio, CancellationToken cancellationToken = default);
    
    /// <summary>
    /// Obtém o payload de uma cobrança com vencimento de forma assíncrona.
    /// </summary>
    /// <param name="pixUrlAccessToken">O token de acesso da URL PIX.</param>
    /// <param name="pagamentoData">A data de pagamento.</param>
    /// <param name="cancellationToken">O token de cancelamento opcional.</param>
    /// <returns>Uma tarefa que representa a operação assíncrona. O resultado é o payload da cobrança com vencimento.</returns>
    Task<CobVPayload> GetCobVPayloadAsync(string pixUrlAccessToken, DateTime pagamentoData, CancellationToken cancellationToken = default);
    
    /// <summary>
    /// Obtém o payload de uma cobrança com vencimento de forma assíncrona.
    /// </summary>
    /// <param name="pixUrlAccessToken">O token de acesso da URL PIX.</param>
    /// <param name="codMunicipio">O código do município.</param>
    /// <param name="pagamentoData">A data de pagamento.</param>
    /// <param name="cancellationToken">O token de cancelamento opcional.</param>
    /// <returns>Uma tarefa que representa a operação assíncrona. O resultado é o payload da cobrança com vencimento.</returns>
    Task<CobVPayload> GetCobVPayloadAsync(string pixUrlAccessToken, string codMunicipio, DateTime pagamentoData, CancellationToken cancellationToken = default);

}
