namespace PixDotNet.Models.LoteCobV
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Representa um lote de solicitações de alteração ou criação de cobranças com vencimento.
    /// </summary>
    public class LoteCobVConsultado
    {
        /// <summary>
        /// Obtém ou define o identificador do lote em formato numérico.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Obtém ou define a descrição do lote.
        /// </summary>
        public string Descricao { get; set; }

        /// <summary>
        /// Obtém ou define a data de criação do lote.
        /// </summary>
        public DateTime Criacao { get; set; }

        /// <summary>
        /// Obtém ou define as solicitações de alteração ou criação de cobranças contidas no lote.
        /// </summary>
        public List<SolicitacaoCobV> Cobs { get; set; }
    }
}
