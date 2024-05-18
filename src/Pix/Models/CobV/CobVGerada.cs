using PixDotNet.Models.Cob;
using PixDotNet.Models.Common;

namespace PixDotNet.Models.CobV
{
    /// <summary>
    /// Representa uma cobrança com vencimento gerada.
    /// </summary>
    public class CobVGerada : CobBaseCopiaCola
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
        /// Obtém ou define os dados do recebedor.
        /// </summary>
        public DadosRecebedor Recebedor { get; set; }

        /// <summary>
        /// Obtém ou define o status da cobrança.
        /// </summary>
        public CobrancaStatus Status { get; set; }

        /// <summary>
        /// Obtém ou define o valor da cobrança.
        /// </summary>
        public CobVValor Valor { get; set; }
    }
}
