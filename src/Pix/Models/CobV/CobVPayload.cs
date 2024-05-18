using PixDotNet.Models.Cob;
using PixDotNet.Models.Common;

namespace PixDotNet.Models.CobV
{
    /// <summary>
    /// Representa o payload JSON da cobrança com vencimento.
    /// </summary>
    public class CobVPayload : CobBase
    {
        /// <summary>
        /// Obtém ou define o ID da transação.
        /// </summary>
        public string Txid { get; set; }

        /// <summary>
        /// Obtém ou define a revisão da cobrança.
        /// </summary>
        public int Revisao { get; set; }

        /// <summary>
        /// Obtém ou define o status da cobrança.
        /// </summary>
        public CobrancaStatus Status { get; set; }

        /// <summary>
        /// Obtém ou define o valor da cobrança.
        /// </summary>
        public CobVPayloadValor Valor { get; set; }

        /// <summary>
        /// Obtém ou define a chave do recebedor.
        /// </summary>
        public DadosRecebedor Recebedor { get; set; }
    }
}
