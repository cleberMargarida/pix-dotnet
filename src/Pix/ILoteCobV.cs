using PixDotNet.Models.LoteCobV;
using System.Threading.Tasks;

using System.Threading;

/// <summary>
/// Interface para operações relacionadas a lotes de cobranças com vencimento no sistema Pix.
/// </summary>
public interface ILoteCobV
{
    /// <summary>
    /// Cria ou altera um lote de cobranças com vencimento de forma assíncrona.
    /// </summary>
    /// <param name="id">O identificador do lote.</param>
    /// <param name="body">O corpo da requisição.</param>
    /// <param name="cancellationToken">O token de cancelamento da operação.</param>
    Task CriarOuAlterarCobVAsync(long id, LoteCobVBody body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Revisa um lote de cobranças com vencimento de forma assíncrona.
    /// </summary>
    /// <param name="id">O identificador do lote.</param>
    /// <param name="body">O corpo da requisição.</param>
    /// <param name="cancellationToken">O token de cancelamento da operação.</param>
    Task ReviewCobVAsync(long id, LoteCobVBody body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Obtém um lote de cobranças com vencimento de forma assíncrona.
    /// </summary>
    /// <param name="id">O identificador do lote.</param>
    /// <param name="cancellationToken">O token de cancelamento da operação.</param>
    /// <returns>Uma tarefa que representa a operação assíncrona. O resultado é o lote de cobranças.</returns>
    Task<LoteCobVConsultado> GetCobVAsync(long id, CancellationToken cancellationToken = default);

    /// <summary>
    /// Lista lotes de cobranças com vencimento de forma assíncrona.
    /// </summary>
    /// <param name="body">O corpo da requisição.</param>
    /// <param name="cancellationToken">O token de cancelamento da operação.</param>
    /// <returns>Uma tarefa que representa a operação assíncrona. O resultado são os lotes de cobranças consultados.</returns>
    Task<LotesCobVConsultados> ListCobVAsync(ParametrosConsultaLote body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Cria ou altera um lote de cobranças com vencimento de forma síncrona.
    /// </summary>
    /// <param name="id">O identificador do lote.</param>
    /// <param name="body">O corpo da requisição.</param>
    void CriarOuAlterarCobV(long id, LoteCobVBody body);

    /// <summary>
    /// Revisa um lote de cobranças com vencimento de forma síncrona.
    /// </summary>
    /// <param name="id">O identificador do lote.</param>
    /// <param name="body">O corpo da requisição.</param>
    void ReviewCobV(long id, LoteCobVBody body);

    /// <summary>
    /// Obtém um lote de cobranças com vencimento de forma síncrona.
    /// </summary>
    /// <param name="id">O identificador do lote.</param>
    /// <returns>O lote de cobranças.</returns>
    LoteCobVConsultado GetCobV(long id);

    /// <summary>
    /// Lista lotes de cobranças com vencimento de forma síncrona.
    /// </summary>
    /// <param name="body">O corpo da requisição.</param>
    /// <returns>Os lotes de cobranças consultados.</returns>
    LotesCobVConsultados ListCobV(ParametrosConsultaLote body);
}
