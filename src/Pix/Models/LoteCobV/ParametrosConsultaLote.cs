namespace PixDotNet.Models.LoteCobV
{
    using PixDotNet.Models.Common;
    using System;
    using System.Collections.Generic;
    using System.Web;

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
