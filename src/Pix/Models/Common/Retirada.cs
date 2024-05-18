namespace PixDotNet.Models.Common
{
    /// <summary>
    /// Estrutura opcional relacionada ao conceito de recebimento de numerário.
    /// Apenas um agrupamento por vez é permitido, quando há saque não há troco e vice-versa.
    /// </summary>
    public class Retirada
    {
        /// <summary>
        /// Informações relacionadas ao saque.
        /// </summary>
        public Saque Saque { get; set; }

        /// <summary>
        /// Informações relacionadas ao troco.
        /// </summary>
        public Troco Troco { get; set; }
    }
}