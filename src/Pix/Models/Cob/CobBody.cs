using System;
using System.Collections.Generic;
using System.Text;
using PixDotNet.Models.Common;

namespace PixDotNet.Models.Cob
{
    /// <summary>
    /// Dados para geração da cobrança imediata.
    /// </summary>
    public class CobBody : CobBase
    {
        /// <summary>
        /// Valores monetários referentes à cobrança.
        /// </summary>
        public CobValor Valor { get; set; }
    }
}
