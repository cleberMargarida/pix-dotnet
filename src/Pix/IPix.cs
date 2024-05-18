using PixDotNet.Models.Common;
using System.Threading;
using System.Threading.Tasks;

/// <summary>
/// Interface para operações relacionadas ao sistema Pix.
/// </summary>
public interface IPix
{
    /// <summary>
    /// Obtém informações de um Pix de forma assíncrona.
    /// </summary>
    /// <param name="e2eid">O identificador da transação Pix.</param>
    /// <param name="cancellationToken">O token de cancelamento da operação.</param>
    /// <returns>Uma tarefa que representa a operação assíncrona. O resultado é o Pix obtido.</returns>
    Task<Pix> GetPixAsync(string e2eid, CancellationToken cancellationToken = default);

    /// <summary>
    /// Lista os Pix recebidos de forma assíncrona.
    /// </summary>
    /// <param name="params">Os parâmetros da consulta.</param>
    /// <param name="cancellationToken">O token de cancelamento da operação.</param>
    /// <returns>Uma tarefa que representa a operação assíncrona. O resultado são os Pix consultados.</returns>
    Task<PixConsultados> ListPixReceivedAsync(ParametrosConsultaPix @params, CancellationToken cancellationToken = default);

    /// <summary>
    /// Solicita a devolução de um Pix de forma assíncrona.
    /// </summary>
    /// <param name="e2eid">O identificador da transação Pix.</param>
    /// <param name="id">O identificador da devolução.</param>
    /// <param name="valor">O valor a ser devolvido.</param>
    /// <param name="cancellationToken">O token de cancelamento da operação.</param>
    /// <returns>Uma tarefa que representa a operação assíncrona. O resultado é a devolução realizada.</returns>
    Task<Devolucao> ReturnPixAsync(string e2eid, string id, decimal valor, CancellationToken cancellationToken = default);

    /// <summary>
    /// Obtém informações de uma devolução de Pix de forma assíncrona.
    /// </summary>
    /// <param name="e2eid">O identificador da transação Pix.</param>
    /// <param name="id">O identificador da devolução.</param>
    /// <param name="cancellationToken">O token de cancelamento da operação.</param>
    /// <returns>Uma tarefa que representa a operação assíncrona. O resultado é a devolução obtida.</returns>
    Task<Devolucao> GetReturnedPixAsync(string e2eid, string id, CancellationToken cancellationToken = default);

    /// <summary>
    /// Obtém informações de um Pix de forma síncrona.
    /// </summary>
    /// <param name="e2eid">O identificador da transação Pix.</param>
    /// <returns>O Pix obtido.</returns>
    Pix GetPix(string e2eid);

    /// <summary>
    /// Lista os Pix recebidos de forma síncrona.
    /// </summary>
    /// <param name="params">Os parâmetros da consulta.</param>
    /// <returns>Os Pix consultados.</returns>
    PixConsultados ListPixReceived(ParametrosConsultaPix @params);

    /// <summary>
    /// Solicita a devolução de um Pix de forma síncrona.
    /// </summary>
    /// <param name="e2eid">O identificador da transação Pix.</param>
    /// <param name="id">O identificador da devolução.</param>
    /// <param name="valor">O valor a ser devolvido.</param>
    /// <returns>A devolução realizada.</returns>
    Devolucao ReturnPix(string e2eid, string id, decimal valor);

    /// <summary>
    /// Obtém informações de uma devolução de Pix de forma síncrona.
    /// </summary>
    /// <param name="e2eid">O identificador da transação Pix.</param>
    /// <param name="id">O identificador da devolução.</param>
    /// <returns>A devolução obtida.</returns>
    Devolucao GetReturnedPix(string e2eid, string id);
}
