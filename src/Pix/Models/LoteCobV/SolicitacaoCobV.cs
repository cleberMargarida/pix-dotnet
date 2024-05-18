namespace PixDotNet.Models.LoteCobV
{
    using PixDotNet.Models.Common;
    using System;

    /// <summary>
    /// Representa uma solicitação de alteração ou criação de cobrança com vencimento no contexto de um lote.
    /// </summary>
    public class SolicitacaoCobV
    {
        /// <summary>
        /// Obtém ou define o ID da transação.
        /// </summary>
        public string Txid { get; set; }

        /// <summary>
        /// Obtém ou define o status da solicitação de criação/alteração da cobrança no contexto de criação via lote.
        /// </summary>
        public CobrancaLoteStatus Status { get; set; }

        /// <summary>
        /// Obtém ou define o problema associado à solicitação, se houver.
        /// </summary>
        public Problema Problema { get; set; }

        /// <summary>
        /// Obtém ou define a data de criação da cobrança.
        /// </summary>
        public DateTime Criacao { get; set; }
    }
}
