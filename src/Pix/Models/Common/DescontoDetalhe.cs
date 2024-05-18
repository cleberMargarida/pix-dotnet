namespace PixDotNet.Models.Common
{
    using System;

    /// <summary>
    /// Classe que representa o detalhe dos descontos.
    /// </summary>
    public class DescontoDetalhe
    {
        /// <summary>
        /// Data limite para o desconto absoluto da cobrança.
        /// </summary>
        public DateTime Data { get; set; }

        /// <summary>
        /// Valor do desconto absoluto.
        /// </summary>
        public decimal ValorPerc { get; set; }
    }


}