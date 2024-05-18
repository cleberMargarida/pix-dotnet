﻿using PixDotNet.Models.CobV;
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
    /// <param name="codMunicipio">O código do município. (Opcional)</param>
    /// <param name="pagamentoData">A data de pagamento. (Opcional)</param>
    /// <param name="cancellationToken">O token de cancelamento opcional.</param>
    /// <returns>Uma tarefa que representa a operação assíncrona. O resultado é o payload da cobrança com vencimento.</returns>
    Task<CobVPayload> GetCobVPayloadAsync(string pixUrlAccessToken, string? codMunicipio = null, DateTime? pagamentoData = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Obtém o payload de uma cobrança com vencimento de forma síncrona.
    /// </summary>
    /// <param name="pixUrlAccessToken">O token de acesso da URL PIX.</param>
    /// <param name="codMunicipio">O código do município. (Opcional)</param>
    /// <param name="pagamentoData">A data de pagamento. (Opcional)</param>
    /// <returns>O payload da cobrança com vencimento.</returns>
    CobVPayload GetCobVPayload(string pixUrlAccessToken, string? codMunicipio = null, DateTime? pagamentoData = null);
}
