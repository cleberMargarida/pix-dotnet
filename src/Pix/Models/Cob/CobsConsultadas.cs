using System.Collections.Generic;
using PixDotNet.Models.Common;

namespace PixDotNet.Models.Cob
{
    /// <summary>
    /// Cobranças imediatas consultadas.
    /// </summary>
    public class CobsConsultadas
    {
        /// <summary>
        /// Parâmetros de consulta.
        /// </summary>
        public ParametrosConsultaCob Parametros { get; set; }

        /// <summary>
        /// Lista de cobranças.
        /// </summary>
        public List<CobCompleta> Cobs { get; set; }
    }
}