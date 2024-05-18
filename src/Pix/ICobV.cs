using PixDotNet.Models.CobV;
using PixDotNet.Models.Common;
using System.Threading;
using System.Threading.Tasks;

/// <summary>
/// Interface para operações relacionadas a cobranças com vencimento (CobV) no sistema Pix.
/// </summary>
public interface ICobV : IVPayload
{
    /// <summary>
    /// Cria uma nova cobrança com vencimento com o ID de transação e corpo especificados de forma assíncrona.
    /// </summary>
    /// <param name="txid">O ID de transação da cobrança com vencimento.</param>
    /// <param name="body">O corpo da cobrança com vencimento.</param>
    /// <param name="cancellationToken">O token de cancelamento opcional.</param>
    /// <returns>Uma tarefa que representa a operação assíncrona. O resultado é a cobrança com vencimento gerada.</returns>
    Task<CobVGerada> CreateCobVAsync(string txid, CobVBody body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Revisa uma cobrança com vencimento existente com o ID de transação e corpo especificados de forma assíncrona.
    /// </summary>
    /// <param name="txid">O ID de transação da cobrança com vencimento.</param>
    /// <param name="body">O corpo da cobrança com vencimento revisada.</param>
    /// <param name="cancellationToken">O token de cancelamento opcional.</param>
    /// <returns>Uma tarefa que representa a operação assíncrona. O resultado é a cobrança com vencimento revisada.</returns>
    Task<CobVRevisada> ReviewCobVAsync(string txid, CobVBody body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Obtém uma cobrança com vencimento com o ID de transação especificado de forma assíncrona.
    /// </summary>
    /// <param name="txid">O ID de transação da cobrança com vencimento.</param>
    /// <param name="cancellationToken">O token de cancelamento opcional.</param>
    /// <returns>Uma tarefa que representa a operação assíncrona. O resultado é a cobrança com vencimento solicitada.</returns>
    Task<CobVGerada> GetCobVAsync(string txid, CancellationToken cancellationToken = default);

    /// <summary>
    /// Lista cobranças com vencimento com base nos parâmetros de consulta especificados de forma assíncrona.
    /// </summary>
    /// <param name="params">Os parâmetros de consulta das cobranças com vencimento.</param>
    /// <param name="cancellationToken">O token de cancelamento opcional.</param>
    /// <returns>Uma tarefa que representa a operação assíncrona. O resultado são as cobranças com vencimento consultadas.</returns>
    Task<CobsVConsultadas> ListCobVAsync(ParametrosConsultaCob @params, CancellationToken cancellationToken = default);

    /// <summary>
    /// Cria uma nova cobrança com vencimento com o ID de transação e corpo especificados de forma síncrona.
    /// </summary>
    CobVGerada CreateCobV(string txid, CobVBody body);

    /// <summary>
    /// Revisa uma cobrança com vencimento existente com o ID de transação e corpo especificados de forma síncrona.
    /// </summary>
    CobVRevisada ReviewCobV(string txid, CobVBody body);

    /// <summary>
    /// Obtém uma cobrança com vencimento com o ID de transação especificado de forma síncrona.
    /// </summary>
    CobVGerada GetCobV(string txid);

    /// <summary>
    /// Lista cobranças com vencimento com base nos parâmetros de consulta especificados de forma síncrona.
    /// </summary>
    CobsVConsultadas ListCobV(ParametrosConsultaCob @params);
}

