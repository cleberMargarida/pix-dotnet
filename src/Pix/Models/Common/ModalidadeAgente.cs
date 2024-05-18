namespace PixDotNet.Models.Common
{
    /// <summary>
    /// Modalidade de alteração de valor do saque. Quando não preenchido o valor assumido é o 0 (zero).
    /// </summary>
    public enum ModalidadeAgente
    {
        /// <summary>
        /// Agente Estabelecimento Comercial.
        /// </summary>
        AGTEC,

        /// <summary>
        /// Agente Outra Espécie de Pessoa Jurídica ou Correspondente no País.
        /// </summary>
        AGTOT,

        /// <summary>
        /// Agente Facilitador de Serviço de Saque 
        /// </summary>
        /// <remarks>
        /// ATENÇÃO: no mapeamento para o campo 'modalidadeAgente', da pacs.008, esse valor deve ser substituído por AGFSS).
        /// </remarks>
        AGPSS
    }
}