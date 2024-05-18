using PixDotNet.Models.Common;

namespace PixDotNet.Models.Cob
{
    public class CobPayload : CobBase
    {
        /// <summary>
        /// TxId.
        /// </summary>
        public string TxId { get; set; }

        /// <summary>
        /// Revisão da cobrança.
        /// </summary>
        public int Revisao { get; set; }

        /// <summary>
        /// Status da cobrança.
        /// </summary>
        public CobrancaStatus Status { get; set; }

        /// <summary>
        /// Valor da cobrança.
        /// </summary>
        public CobPayloadValor Valor { get; set; }
    }
}