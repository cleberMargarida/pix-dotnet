using System;

namespace PixDotNet.Models.Common
{
    /// <summary>
    /// Location do Payload.
    /// </summary>
    /// <remarks>
    /// Identificador da localização do payload.
    /// </remarks>
    public class PayloadLocation
    {
        /// <summary>
        /// Identificador da location a ser informada na criação da cobrança.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Tipo da cobrança.
        /// </summary>
        public TipoCob TipoCob { get; set; }

        /// <summary>
        /// Identificador da transação.
        /// </summary>
        public string Txid { get; set; }

        /// <summary>
        /// Localização do Payload a ser informada na criação da cobrança.
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// Data e hora em que a location foi criada. Respeita RFC 3339.
        /// </summary>
        public DateTime Criacao { get; set; }
    }
}
