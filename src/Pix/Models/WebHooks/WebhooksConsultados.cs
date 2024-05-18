using System.Collections.Generic;

namespace PixDotNet.Models.WebHooks
{
    /// <summary>
    /// Representa a resposta de uma consulta de Webhooks.
    /// </summary>
    public class WebhooksConsultados
    {
        /// <summary>
        /// Parâmetros da consulta realizada.
        /// </summary>
        public ParametrosConsultaWebhooks Parametros { get; set; }

        /// <summary>
        /// Lista de Webhooks consultados.
        /// </summary>
        public List<Webhook> Webhooks { get; set; }
    }

}
