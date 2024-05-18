namespace PixDotNet.Models.WebHooks
{
    using PixDotNet.Models.Common;
    using System;

    /// <summary>
    /// Parâmetros utilizados para a realização de uma consulta de Webhooks.
    /// </summary>
    public class ParametrosConsultaWebhooks
    {
        /// <summary>
        /// Data inicial utilizada na consulta. Respeita RFC 3339.
        /// </summary>
        public DateTime Inicio { get; set; }

        /// <summary>
        /// Data de fim utilizada na consulta. Respeita RFC 3339.
        /// </summary>
        public DateTime Fim { get; set; }

        /// <summary>
        /// Paginação dos resultados da consulta.
        /// </summary>
        public Paginacao Paginacao { get; set; }
    }

}
