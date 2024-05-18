namespace PixDotNet.Models.LoteCobV
{
    using PixDotNet.Models.Common;
    using System;

    /// <summary>
    /// Parâmetros de consulta de lotes de cobrança com vencimento.
    /// </summary>
    public class ParametrosConsultaLote
    {
        /// <summary>
        /// Obtém ou define a data de início utilizada na consulta.
        /// </summary>
        public DateTime? Inicio { get; set; }

        /// <summary>
        /// Obtém ou define a data de fim utilizada na consulta.
        /// </summary>
        public DateTime? Fim { get; set; }

        /// <summary>
        /// Obtém ou define os parâmetros de paginação.
        /// </summary>
        public Paginacao Paginacao { get; set; }
    }
}
