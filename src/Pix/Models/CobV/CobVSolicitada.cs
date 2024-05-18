using PixDotNet.Models.Common;

namespace PixDotNet.Models.CobV
{
    public class CobVSolicitada : CobBase
    {
        /// <summary>
        /// Obtém ou define o valor da cobrança.
        /// </summary>
        public CobVValor Valor { get; set; }
    }
}
