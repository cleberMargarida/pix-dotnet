using System.Text.RegularExpressions;
using System;
using PixDotNet.Models.Common;

namespace PixDotNet.Models.CobV
{
    /// <summary>
    /// Representa os valores monetários referentes à cobrança com vencimento.
    /// </summary>
    public class CobVValor
    {
        /// <summary>
        /// Valor original da cobrança.
        /// </summary>
        public decimal Original { get; set; }

        /// <summary>
        /// Multa aplicada à cobrança.
        /// </summary>
        public Multa Multa { get; set; }

        /// <summary>
        /// Juro aplicado à cobrança.
        /// </summary>
        public Juro Juros { get; set; }

        /// <summary>
        /// Abatimento aplicado à cobrança.
        /// </summary>
        public Abatimento Abatimento { get; set; }

        /// <summary>
        /// Descontos aplicados à cobrança.
        /// </summary>
        public Desconto Desconto { get; set; }
    }
}