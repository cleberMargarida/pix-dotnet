using PixDotNet.Models.Common;

namespace PixDotNet.Models.Cob
{
    /// <summary>
    /// Cobrança imediata revisada.
    /// Dados enviados para revisão da cobrança imediata via API Pix.
    /// </summary>
    public class CobRevisada : CobBase
    {
        /// <summary>
        /// Calendário.
        /// Os campos aninhados sob o identificador calendário organizam informações a respeito de controle de tempo da cobrança.
        /// </summary>
        public Calendario Calendario { get; set; }

        /// <summary>
        /// Devedor.
        /// Os campos aninhados sob o objeto devedor são opcionais e identificam o devedor, ou seja, a pessoa ou a instituição a quem a cobrança está endereçada.
        /// </summary>
        public DadosDevedor Devedor { get; set; }

        /// <summary>
        /// Payload Location Cob.
        /// </summary>
        public PayloadLocation Loc { get; set; }

        /// <summary>
        /// Status do registro da cobrança.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Valor.
        /// </summary>
        public CobValor Valor { get; set; }
    }

}