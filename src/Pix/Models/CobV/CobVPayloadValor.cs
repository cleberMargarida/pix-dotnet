using PixDotNet.Models.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace PixDotNet.Models.CobV
{
    /// <summary>
    /// Representa o valor da cobrança com vencimento calculada retornada pelo payload.
    /// </summary>
    public class CobVPayloadValor
    {
        /// <summary>
        /// Obtém ou define o valor original da cobrança.
        /// </summary>
        /// <remarks>
        /// Valor original da cobrança.
        /// </remarks>
        public decimal? Original { get; set; }

        /// <summary>
        /// Obtém ou define a multa aplicada à cobrança.
        /// </summary>
        /// <remarks>
        /// Multa aplicada à cobrança.
        /// </remarks>
        public decimal? Multa { get; set; }

        /// <summary>
        /// Obtém ou define o juro aplicado à cobrança.
        /// </summary>
        /// <remarks>
        /// Juro aplicado à cobrança.
        /// </remarks>
        public decimal? Juros { get; set; }

        /// <summary>
        /// Obtém ou define o abatimento aplicado à cobrança.
        /// </summary>
        /// <remarks>
        /// Abatimento aplicado à cobrança.
        /// </remarks>
        public decimal? Abatimento { get; set; }

        /// <summary>
        /// Obtém ou define os descontos aplicados à cobrança.
        /// </summary>
        /// <remarks>
        /// Descontos aplicados à cobrança.
        /// </remarks>
        public decimal? Desconto { get; set; }

        /// <summary>
        /// Obtém ou define o valor final da cobrança.
        /// </summary>
        /// <remarks>
        /// Valor final da cobrança.
        /// </remarks>
        public decimal Final { get; set; }
    }
}
