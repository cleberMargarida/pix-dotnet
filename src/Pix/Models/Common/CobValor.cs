namespace PixDotNet.Models.Common
{
    /// <summary>
    /// Representa os valores monetários referentes à cobrança.
    /// </summary>
    public class CobValor
    {
        /// <summary>
        /// Valor original da cobrança.
        /// </summary>
        public decimal Original { get; set; }

        /// <summary>
        /// Trata-se de um campo que determina se o valor final do documento pode ser alterado pelo pagador.
        /// Na ausência desse campo, assume-se que não se pode alterar o valor do documento de cobrança, ou seja, assume-se o valor 0.
        /// Se o campo estiver presente e com valor 1, então está determinado que o valor final da cobrança pode ter seu valor alterado pelo pagador.
        /// </summary>
        public int? ModalidadeAlteracao { get; set; }

        /// <summary>
        /// É uma estrutura opcional relacionada ao conceito de recebimento de numerário.
        /// Apenas um agrupamento por vez é permitido, quando há saque não há troco e vice-versa.
        /// Quando uma cobrança imediata tem uma estrutura de retirada ela deixa de ser considerada Pix comum e passa à categoria de Pix Saque ou Pix Troco.
        /// </summary>
        public Retirada Retirada { get; set; }
    }
}