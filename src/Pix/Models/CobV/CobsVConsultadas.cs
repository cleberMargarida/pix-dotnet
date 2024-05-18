using PixDotNet.Models.Common;
using System.Collections.Generic;

namespace PixDotNet.Models.CobV
{
    /// <summary>
    /// Representa as cobranças com vencimento consultadas.
    /// </summary>
    public class CobsVConsultadas
    {
        /// <summary>
        /// Obtém ou define os parâmetros da consulta.
        /// </summary>
        public ParametrosConsultaCob Parametros { get; set; }

        /// <summary>
        /// Obtém ou define a lista de cobranças.
        /// </summary>
        public List<CobVCompleta> Cobs { get; set; }
    }

}
