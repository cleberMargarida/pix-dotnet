namespace PixDotNet.Models.Common
{
    /// <summary>
    /// Classe que representa o abatimento aplicado à cobrança.
    /// </summary>
    public class Abatimento
    {
        /// <summary>
        /// Modalidade de abatimentos.
        /// </summary>
        public AbatimentoModalidade Modalidade { get; set; }

        /// <summary>
        /// Valor.
        /// </summary>
        public decimal ValorPerc { get; set; }
    }


}