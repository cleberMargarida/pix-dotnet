namespace PixDotNet.Models.LoteCobV
{
    using System.Collections.Generic;

    /// <summary>
    /// Representa um lote de solicitações de cobranças com vencimento consultadas.
    /// </summary>
    public class LotesCobVConsultados
    {
        /// <summary>
        /// Obtém ou define os parâmetros da consulta do lote.
        /// </summary>
        public ParametrosConsultaLote Parametros { get; set; }

        /// <summary>
        /// Obtém ou define a lista de lotes consultados.
        /// </summary>
        public List<LoteCobVConsultado> Lotes { get; set; }
    }
}
