namespace PixDotNet.Models.Common
{
    /// <summary>
    /// Classe base para operações monetárias.
    /// </summary>
    public abstract class OperacaoMonetaria
    {
        /// <summary>
        /// Valor da operação monetária.
        /// </summary>
        public decimal Valor { get; set; }

        /// <summary>
        /// Modalidade de alteração do valor da operação.
        /// Quando não preenchido, o valor assumido é 0 (zero).
        /// </summary>
        public int ModalidadeAlteracao { get; set; }

        /// <summary>
        /// Modalidade do agente.
        /// </summary>
        public ModalidadeAgente ModalidadeAgente { get; set; }

        /// <summary>
        /// ISPB do provedor de serviço para a operação monetária.
        /// </summary>
        public string PrestadorDoServico { get; set; }
    }
}