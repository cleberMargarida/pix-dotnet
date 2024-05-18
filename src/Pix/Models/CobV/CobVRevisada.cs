using PixDotNet.Models.Cob;
using PixDotNet.Models.Common;

namespace PixDotNet.Models.CobV
{
    public class CobVRevisada : CobBase
    {
        /// <summary>
        /// Status do registro da cobrança.
        /// </summary>
        public CobrancaStatus Status { get; set; }

        /// <summary>
        /// Obtém ou define o valor da cobrança.
        /// </summary>
        public CobVValor Valor { get; set; }
    }
}
