using PixDotNet.Models.Cob;
using System.Threading;
using System.Threading.Tasks;

/// <summary>
/// Interface para operações relacionadas aos payloads de cobranças no sistema Pix.
/// </summary>
public interface IPayload
{
    /// <summary>
    /// Obtém o payload de uma cobrança de forma assíncrona.
    /// </summary>
    /// <param name="pixUrlAccessToken">O token de acesso da URL PIX.</param>
    /// <param name="cancellationToken">O token de cancelamento da operação.</param>
    /// <returns>Uma tarefa que representa a operação assíncrona. O resultado é o payload da cobrança.</returns>
    Task<CobPayload> GetCobPayloadAsync(string pixUrlAccessToken, CancellationToken cancellationToken = default);

    /// <summary>
    /// Obtém o payload de uma cobrança de forma síncrona.
    /// </summary>
    /// <param name="pixUrlAccessToken">O token de acesso da URL PIX.</param>
    /// <returns>O payload da cobrança.</returns>
    CobPayload GetCobPayload(string pixUrlAccessToken);
}
