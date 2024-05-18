using System.Collections.Generic;

namespace PixDotNet.Models.Cob
{
    /// <summary>
    /// Cobrança imediata completa.
    /// </summary>
    public class CobCompleta
    {
        /// <summary>
        /// Cobrança solicitada.
        /// </summary>
        public CobSolicitada CobSolicitada { get; set; }

        /// <summary>
        /// Cobrança gerada.
        /// </summary>
        public CobGerada CobGerada { get; set; }

        /// <summary>
        /// Status da cobrança.
        /// </summary>
        public CobrancaStatus Status { get; set; }

        /// <summary>
        /// Pix recebidos.
        /// </summary>
        public List<Pix> Pix { get; set; }
    }
}