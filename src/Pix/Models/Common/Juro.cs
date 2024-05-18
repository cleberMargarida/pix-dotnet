namespace PixDotNet.Models.Common
{
    /// <summary>
    /// Classe que representa o juro aplicado à cobrança.
    /// </summary>
    public class Juro
    {
        /// <summary>
        /// Modalidade de juros.
        /// </summary>
        public JuroModalidade Modalidade { get; set; }

        /// <summary>
        /// Valor.
        /// </summary>
        public decimal ValorPerc { get; set; }
    }


}