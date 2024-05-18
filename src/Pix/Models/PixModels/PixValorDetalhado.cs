using PixDotNet.Models.Common;

public class PixValorDetalhado : PixValor
{
    /// <summary>
    /// Obtém ou define a modalidade do agente.
    /// </summary>
    /// <remarks>
    /// <list type="bullet">
    /// <item>
    /// <term>AGTEC</term>
    /// <description>Agente Estabelecimento Comercial</description>
    /// </item>
    /// <item>
    /// <term>AGTOT</term>
    /// <description>Agente Outra Espécie de Pessoa Jurídica ou Correspondente no País</description>
    /// </item>
    /// <item>
    /// <term>AGPSS</term>
    /// <description>Agente Facilitador de Serviço de Saque (ATENÇÃO: no mapeamento para o campo 'modalidadeAgente', da pacs.008, esse valor deve ser substituído por AGFSS)</description>
    /// </item>
    /// </list>
    /// </remarks>
    public ModalidadeAgente ModalidadeAgente { get; set; }

    /// <summary>
    /// Obtém ou define o ISPB do facilitador do serviço de saque.
    /// </summary>
    /// <remarks>
    /// ISPB do facilitador do serviço de saque.
    /// </remarks>
    public string PrestadorDeServicoDeSaque { get; set; }
}
