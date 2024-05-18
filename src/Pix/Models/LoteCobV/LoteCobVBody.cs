namespace PixDotNet.Models.LoteCobV
{
    using System.Collections.Generic;

    /// <summary>
    /// Dados para geração de lote de cobranças com vencimento.
    /// </summary>
    public class LoteCobVBody
    {
        /// <summary>
        /// Descrição do lote.
        /// </summary>
        public string Descricao { get; set; }

        /// <summary>
        /// Cobranças no lote.
        /// </summary>
        public List<LoteCobVCobSolicitada> Cobsv { get; set; }
    }
}
