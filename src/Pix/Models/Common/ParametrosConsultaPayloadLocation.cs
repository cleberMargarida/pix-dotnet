using System;
using System.Collections.Generic;
using System.Web;

namespace PixDotNet.Models.Common
{
    public class ParametrosConsultaPayloadLocation
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
        /// Filtro pela existência de txid.
        /// </summary>
        public bool TxIdPresente { get; set; }

        /// <summary>
        /// Tipo de cobrança.
        /// </summary>
        /// <remarks>
        /// Valores possíveis: "cob" ou "cobv".
        /// </remarks>
        public TipoCob TipoCob { get; set; }

        /// <summary>
        /// Paginação dos resultados da consulta.
        /// </summary>
        public Paginacao? Paginacao { get; set; }

        internal string ToQueryString()
        {
            return string.Join("&", QueryParameters);
        }

        private IEnumerable<string> QueryParameters
        {
            get
            {
                if (Inicio != default)
                {
                    yield return $"inicio={HttpUtility.UrlEncode(Inicio.ToString("yyyy-MM-ddTHH:mm:ss"))}";
                }

                if (Fim != default)
                {
                    yield return $"fim={HttpUtility.UrlEncode(Fim.ToString("yyyy-MM-ddTHH:mm:ss"))}";
                }

                yield return $"txIdPresente={TxIdPresente.ToString().ToLower()}";

                yield return $"tipoCob={TipoCob.ToString().ToLower()}";

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