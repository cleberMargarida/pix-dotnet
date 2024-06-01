namespace PixDotNet.Models.WebHooks
{
    using PixDotNet.Models.Common;
    using System;
    using System.Collections.Generic;
    using System.Web;

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
        public Paginacao? Paginacao { get; set; }

        internal string ToQueryString()
        {
            return string.Join("&", QueryParamters);
        }

        private IEnumerable<string> QueryParamters
        {
            get
            {
                if (Inicio != default)
                {
                    yield return $"inicio={Inicio:MM-dd-yyyy}";
                }

                if (Fim != default)
                {
                    yield return $"fim={Fim:MM-dd-yyyy}";
                }

                if (Paginacao == null)
                {
                    yield break;
                }

                if (Paginacao.PaginaAtual > 0)
                {
                    yield return $"paginacao.paginaAtual={Paginacao.PaginaAtual}";
                }

                if (Paginacao.ItensPorPagina > 0)
                {
                    yield return $"paginacao.itensPorPagina={Paginacao.ItensPorPagina}";
                }
            }
        }
    }
}
