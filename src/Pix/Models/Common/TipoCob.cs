namespace PixDotNet.Models.Common
{
    public enum TipoCob
    {
        cob,
        cobv
    }

    internal class TipoCobPayload
    {
        public TipoCobPayload()
        {
            
        }

        public TipoCobPayload(TipoCob tipoCob)
        {
            TipoCob = tipoCob;
        }

        public TipoCob TipoCob { get; set; }
    }
}