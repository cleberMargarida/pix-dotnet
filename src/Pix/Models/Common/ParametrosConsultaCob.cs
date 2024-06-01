using System;
using System.Collections.Generic;
using System.Web;

namespace PixDotNet.Models.Common
{
    /// <summary>
    /// Parâmetros de Consulta de Cobrança.
    /// </summary>
    /// <remarks>
    /// Parâmetros utilizados para a realização de uma consulta de cobranças.
    /// </remarks>
    public class ParametrosConsultaCob
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
        /// Filtro pelo CPF do devedor. Não pode ser utilizado ao mesmo tempo que o CNPJ.
        /// </summary>
        public string? Cpf { get; set; }

        /// <summary>
        /// Filtro pelo CNPJ do devedor. Não pode ser utilizado ao mesmo tempo que o CPF.
        /// </summary>
        public string? Cnpj { get; set; }

        /// <summary>
        /// Filtro pela existência de location vinculada.
        /// </summary>
        public bool? LocationPresente { get; set; }

        /// <summary>
        /// Filtro pelo status das cobranças.
        /// </summary>
        public string? Status { get; set; }

        /// <summary>
        /// Parâmetros de paginação.
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

                if (!string.IsNullOrEmpty(Cpf))
                {
                    yield return $"cpf={HttpUtility.UrlEncode(Cpf)}";
                }

                if (!string.IsNullOrEmpty(Cnpj))
                {
                    yield return $"cnpj={HttpUtility.UrlEncode(Cnpj)}";
                }

                if (LocationPresente.HasValue)
                {
                    yield return $"locationPresente={LocationPresente.Value.ToString().ToLower()}";
                }

                if (!string.IsNullOrEmpty(Status))
                {
                    yield return $"status={HttpUtility.UrlEncode(Status)}";
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
