namespace PixDotNet.Models.Common
{
    /// <summary>
    /// Classe que representa a multa aplicada à cobrança.
    /// </summary>
    public class Multa
    {
        /// <summary>
        /// Modalidade da multa.
        /// </summary>
        public MultaModalidade Modalidade { get; set; }

        /// <summary>
        /// Valor da multa absoluta.
        /// </summary>
        public decimal ValorPerc { get; set; }
    }


}