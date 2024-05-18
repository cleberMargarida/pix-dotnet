using PixDotNet.Models.Common;
using System.Threading.Tasks;

using System.Threading;

/// <summary>
/// Interface para operações relacionadas a localização de payloads no sistema Pix.
/// </summary>
public interface IPayloadLocation
{
    /// <summary>
    /// Cria uma localização de payload de forma assíncrona.
    /// </summary>
    /// <param name="tipoCob">O tipo de cobrança.</param>
    /// <param name="cancellationToken">O token de cancelamento da operação.</param>
    /// <returns>Uma tarefa que representa a operação assíncrona. O resultado é a localização de payload criada.</returns>
    Task<PayloadLocation> CreatePayloadLocationAsync(TipoCob tipoCob, CancellationToken cancellationToken = default);

    /// <summary>
    /// Obtém uma localização de payload de forma assíncrona.
    /// </summary>
    /// <param name="id">O identificador da localização de payload.</param>
    /// <param name="cancellationToken">O token de cancelamento da operação.</param>
    /// <returns>Uma tarefa que representa a operação assíncrona. O resultado é a localização de payload obtida.</returns>
    Task<PayloadLocation> GetPayloadLocationAsync(long id, CancellationToken cancellationToken = default);

    /// <summary>
    /// Lista localizações de payload de forma assíncrona.
    /// </summary>
    /// <param name="params">Os parâmetros da consulta.</param>
    /// <param name="cancellationToken">O token de cancelamento da operação.</param>
    /// <returns>Uma tarefa que representa a operação assíncrona. O resultado são as localizações de payload consultadas.</returns>
    Task<PayloadLocationConsultadas> ListPayloadLocationAsync(ParametrosConsultaPayloadLocation @params, CancellationToken cancellationToken = default);

    /// <summary>
    /// Deleta uma localização de payload de forma assíncrona.
    /// </summary>
    /// <param name="id">O identificador da localização de payload.</param>
    /// <param name="cancellationToken">O token de cancelamento da operação.</param>
    /// <returns>Uma tarefa que representa a operação assíncrona. O resultado é a localização de payload deletada.</returns>
    Task<PayloadLocation> DeletePayloadLocationAsync(long id, CancellationToken cancellationToken = default);

    /// <summary>
    /// Cria uma localização de payload de forma síncrona.
    /// </summary>
    /// <param name="tipoCob">O tipo de cobrança.</param>
    /// <returns>A localização de payload criada.</returns>
    PayloadLocation CreatePayloadLocation(TipoCob tipoCob);

    /// <summary>
    /// Obtém uma localização de payload de forma síncrona.
    /// </summary>
    /// <param name="id">O identificador da localização de payload.</param>
    /// <returns>A localização de payload obtida.</returns>
    PayloadLocation GetPayloadLocation(long id);

    /// <summary>
    /// Lista localizações de payload de forma síncrona.
    /// </summary>
    /// <param name="params">Os parâmetros da consulta.</param>
    /// <returns>As localizações de payload consultadas.</returns>
    PayloadLocationConsultadas ListPayloadLocation(ParametrosConsultaPayloadLocation @params);

    /// <summary>
    /// Deleta uma localização de payload de forma síncrona.
    /// </summary>
    /// <param name="id">O identificador da localização de payload.</param>
    /// <returns>A localização de payload deletada.</returns>
    PayloadLocation DeletePayloadLocation(long id);
}
