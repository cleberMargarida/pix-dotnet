using PixDotNet.Models.Cob;
using System.Collections.Generic;

namespace PixDotNet.Models.CobV
{
    /// <summary>
    /// Representa uma cobrança com vencimento completa.
    /// </summary>
    public class CobVCompleta
    {
        /// <summary>
        /// Obtém ou define a cobrança solicitada.
        /// </summary>
        public CobVSolicitada Solicitada { get; set; }

        /// <summary>
        /// Obtém ou define a cobrança gerada.
        /// </summary>
        public CobVGerada Gerada { get; set; }

        /// <summary>
        /// Obtém ou define a lista de Pix recebidos.
        /// </summary>
        public List<Pix> Pix { get; set; }

        /// <summary>
        /// Obtém ou define o status da cobrança.
        /// </summary>
        public CobrancaStatus Status { get; set; }
    }
}
