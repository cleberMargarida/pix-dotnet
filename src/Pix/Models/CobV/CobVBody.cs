using PixDotNet.Models.Common;

namespace PixDotNet.Models.CobV
{
    /// <summary>
    /// Dados para geração da cobrança com vencimento.
    /// </summary>
    public class CobVBody : CobBase
    {
        /// <summary>
        /// Valores monetários referentes à cobrança vencida.
        /// </summary>
        public CobVValor Valor { get; set; }
    }
}
