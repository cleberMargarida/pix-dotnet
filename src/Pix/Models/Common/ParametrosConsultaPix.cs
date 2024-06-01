using System;
using System.Collections.Generic;
using System.Web;

namespace PixDotNet.Models.Common
{
    /// <summary>
    /// Parâmetros de Consulta Pix.
    /// </summary>
    public class ParametrosConsultaPix
    {
        /// <summary>
        /// Data de Início. Respeita RFC 3339.
        /// </summary>
        public DateTime Inicio { get; set; }

        /// <summary>
        /// Data de Fim. Respeita RFC 3339.
        /// </summary>
        public DateTime Fim { get; set; }

        /// <summary>
        /// TxId. Deve ter entre 1 e 35 caracteres alfanuméricos.
        /// </summary>
        public string? Txid { get; set; }

        /// <summary>
        /// Filtro pela existência de txid.
        /// </summary>
        public bool TxIdPresente { get; set; }

        /// <summary>
        /// Filtro pela existência de devolução.
        /// </summary>
        public bool DevolucaoPresente { get; set; }

        /// <summary>
        /// CPF.
        /// </summary>
        public string? Cpf { get; set; }

        /// <summary>
        /// CNPJ.
        /// </summary>
        public string? Cnpj { get; set; }

        /// <summary>
        /// Paginação.
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
                    yield return $"inicio={Inicio:MM-dd-yyyy}";
                }

                if (Fim != default)
                {
                    yield return $"fim={Fim:MM-dd-yyyy}";
                }

                if (!string.IsNullOrEmpty(Txid))
                {
                    yield return $"txid={HttpUtility.UrlEncode(Txid)}";
                }

                if (TxIdPresente)
                {
                    yield return $"txIdPresente=true";
                }

                if (DevolucaoPresente)
                {
                    yield return $"devolucaoPresente=true";
                }

                if (!string.IsNullOrEmpty(Cpf))
                {
                    yield return $"cpf={HttpUtility.UrlEncode(Cpf)}";
                }

                if (!string.IsNullOrEmpty(Cnpj))
                {
                    yield return $"cnpj={HttpUtility.UrlEncode(Cnpj)}";
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
