namespace PixDotNet.Models.Common
{
    using System.Collections.Generic;

    /// <summary>
    /// Classe que representa os descontos aplicados à cobrança.
    /// </summary>
    public class Desconto
    {
        /// <summary>
        /// Modalidade de descontos.
        /// </summary>
        public DescontoModalidade Modalidade { get; set; }

        /// <summary>
        /// Lista de descontos.
        /// </summary>
        public List<DescontoDetalhe> DescontoDataFixa { get; set; }

        /// <summary>
        /// Valor do desconto absoluto.
        /// </summary>
        public decimal ValorPerc { get; set; }
    }


}