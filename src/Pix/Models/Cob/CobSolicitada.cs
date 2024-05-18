using PixDotNet.Models.Common;

namespace PixDotNet.Models.Cob
{
    /// <summary>
    /// Cobrança imediata solicitada.
    /// Dados enviados para criação ou alteração da cobrança imediata via API Pix.
    /// </summary>
    public class CobSolicitada : CobBase
    {
        /// <summary>
        /// Obtém ou define o valor da cobrança.
        /// </summary>
        public CobValor Valor { get; set; }
    }
}