using PixDotNet.Models.Cob;
using PixDotNet.Models.Common;
using System.Threading;
using System.Threading.Tasks;

/// <summary>
/// Interface para operações relacionadas a cobranças imediatas (Cob) no sistema Pix.
/// </summary>
public interface ICob
{
    /// <summary>
    /// Cria uma nova cobrança com o ID de transação e corpo especificados de forma assíncrona.
    /// </summary>
    /// <param name="txid">O ID de transação da cobrança.</param>
    /// <param name="body">O corpo da cobrança.</param>
    /// <param name="cancellationToken">O token de cancelamento opcional.</param>
    /// <returns>Uma tarefa que representa a operação assíncrona. O resultado é a cobrança gerada.</returns>
    Task<CobGerada> CreateCobAsync(string txid, CobBody body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Revisa uma cobrança existente com o ID de transação e corpo especificados de forma assíncrona.
    /// </summary>
    /// <param name="txid">O ID de transação da cobrança.</param>
    /// <param name="body">O corpo da cobrança revisada.</param>
    /// <param name="cancellationToken">O token de cancelamento opcional.</param>
    /// <returns>Uma tarefa que representa a operação assíncrona. O resultado é a cobrança revisada.</returns>
    Task<CobRevisada> ReviewCobAsync(string txid, CobBody body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Obtém uma cobrança com o ID de transação especificado de forma assíncrona.
    /// </summary>
    /// <param name="txid">O ID de transação da cobrança.</param>
    /// <param name="cancellationToken">O token de cancelamento opcional.</param>
    /// <returns>Uma tarefa que representa a operação assíncrona. O resultado é a cobrança solicitada.</returns>
    Task<CobSolicitada> GetCobAsync(string txid, CancellationToken cancellationToken = default);
    
    /// <summary>
    /// Obtém uma cobrança com o ID de transação especificado de forma assíncrona.
    /// </summary>
    /// <param name="txid">O ID de transação da cobrança.</param>
    /// <param name="revisao">A revisão da cobrança a ser obtida (opcional).</param>
    /// <param name="cancellationToken">O token de cancelamento opcional.</param>
    /// <returns>Uma tarefa que representa a operação assíncrona. O resultado é a cobrança solicitada.</returns>
    Task<CobSolicitada> GetCobAsync(string txid, int revisao, CancellationToken cancellationToken = default);

    /// <summary>
    /// Cria uma nova cobrança com o corpo especificado de forma assíncrona.
    /// </summary>
    /// <param name="body">O corpo da cobrança.</param>
    /// <param name="cancellationToken">O token de cancelamento opcional.</param>
    /// <returns>Uma tarefa que representa a operação assíncrona. O resultado é a cobrança gerada.</returns>
    Task<CobGerada> CreateCobAsync(CobBody body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Lista cobranças com base nos parâmetros de consulta especificados de forma assíncrona.
    /// </summary>
    /// <param name="payload">Os parâmetros de consulta das cobranças.</param>
    /// <param name="cancellationToken">O token de cancelamento opcional.</param>
    /// <returns>Uma tarefa que representa a operação assíncrona. O resultado são as cobranças consultadas.</returns>
    Task<CobsConsultadas> ListCobAsync(ParametrosConsultaCob payload, CancellationToken cancellationToken = default);
}
