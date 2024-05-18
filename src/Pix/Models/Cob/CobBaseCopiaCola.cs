using PixDotNet.Models.Common;

namespace PixDotNet.Models.Cob
{
    /// <summary>
    /// Cobrança Base com Copia e Cola.
    /// Atributos comuns a todas entidades de Cobrança que possuem informação de Copia e Cola.
    /// </summary>
    public class CobBaseCopiaCola : CobBase
    {
        /// <summary>
        /// Pix Copia e Cola correspondente à cobrança.
        /// Este campo retorna o valor do Pix Copia e Cola correspondente à cobrança.
        /// Trata-se da sequência de caracteres que representa o BR Code.
        /// </summary>
        public string PixCopiaECola { get; set; }
    }
}