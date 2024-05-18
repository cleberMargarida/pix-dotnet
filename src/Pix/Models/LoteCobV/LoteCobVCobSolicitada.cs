namespace PixDotNet.Models.LoteCobV
{
    using PixDotNet.Models.CobV;

    /// <summary>
    /// Cobranças no lote.
    /// </summary>
    public class LoteCobVCobSolicitada
    {
        /// <summary>
        /// ID da transação.
        /// </summary>
        public string Txid { get; set; }

        /// <summary>
        /// Cobrança solicitada.
        /// </summary>
        public CobVSolicitada CobSolicitada { get; set; }
    }
}
