using System;

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
        public Paginacao Paginacao { get; set; }
    }

}
