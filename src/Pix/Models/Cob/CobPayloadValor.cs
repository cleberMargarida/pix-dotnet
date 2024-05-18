using PixDotNet.Models.Common;

namespace PixDotNet.Models.Cob
{
    /// <summary>
    /// Valor da cobrança imediata retornada pelo payload.
    /// </summary>
    public class CobPayloadValor
    {
        /// <summary>
        /// Valor original da cobrança.
        /// </summary>
        public decimal Original { get; set; }

        /// <summary>
        /// Modalidade de alteração.
        /// Trata-se de um campo que determina se o valor final do documento pode ser alterado pelo pagador.
        /// </summary>
        public int? ModalidadeAlteracao { get; set; }

        /// <summary>
        /// Informações de retirada.
        /// </summary>
        public Retirada? Retirada { get; set; }
    }
}