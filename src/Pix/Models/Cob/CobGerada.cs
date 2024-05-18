using PixDotNet.Models.Common;

namespace PixDotNet.Models.Cob
{
    /// <summary>
    /// Cobrança imediata gerada.
    /// Dados criados ou alterados da cobrança imediata via API Pix.
    /// </summary>
    public class CobGerada : CobBaseCopiaCola
    {
        /// <summary>
        /// Calendário.
        /// Os campos aninhados sob o identificador calendário organizam informações a respeito de controle de tempo da cobrança.
        /// </summary>
        public Calendario Calendario { get; set; }

        /// <summary>
        /// TxId.
        /// </summary>
        public string TxId { get; set; }

        /// <summary>
        /// Revisão.
        /// </summary>
        /// <remarks>
        /// Denota a revisão da cobrança.  Sempre começa em zero. Sempre varia em acréscimos de 1.
        /// O incremento em uma cobrança deve ocorrer sempre que um objeto da cobrança em questão for alterado.
        /// O campo `loc` é uma exceção a esta regra.
        /// Se em uma determinada alteração em uma cobrança, o único campo alterado for o campo `loc`,
        /// então esta operação não incrementa a revisão da cobrança.
        /// O campo `loc` não ocasiona uma alteração na cobrança em si.
        /// Não é necessário armazenar histórico das alterações do campo `loc` para uma determinada cobrança.
        /// Para os outros campos da cobrança, registra-se histórico.
        /// </remarks>
        public int Revisao { get; set; }

        /// <summary>
        /// Devedor.
        /// Os campos aninhados sob o objeto devedor são opcionais e identificam o devedor, ou seja, a pessoa ou a instituição a quem a cobrança está endereçada.
        /// </summary>
        public DadosDevedor Devedor { get; set; }

        /// <summary>
        /// Payload Location.
        /// </summary>
        public PayloadLocation Loc { get; set; }

        /// <summary>
        /// Localização do payload.
        /// Localização do Payload a ser informada na criação da cobrança.
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// Status da cobrança.
        /// </summary>
        public CobrancaStatus Status { get; set; }

        /// <summary>
        /// Valor.
        /// </summary>
        public CobValor Valor { get; set; }
    }

}