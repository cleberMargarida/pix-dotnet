using PixDotNet.Models.Common;
using System;
using System.Collections.Generic;

/// <summary>
/// Representa um objeto Pix.
/// </summary>
public class Pix
{
    /// <summary>
    /// Id fim a fim da transação que transita na PACS002, PACS004 e PACS008.
    /// </summary>
    public string EndToEndId { get; set; }

    /// <summary>
    /// Id da Transação.
    /// </summary>
    public string? Txid { get; set; }

    /// <summary>
    /// Valor do Pix.
    /// </summary>
    public decimal Valor { get; set; }

    /// <summary>
    /// Informações sobre o valor do Pix.
    /// </summary>
    public ComponentesValor? ComponentesValor { get; set; }

    /// <summary>
    /// Chave DICT do recebedor.
    /// </summary>
    /// <remarks>
    /// <list type="bullet">
    /// <item>
    /// <term>Campo chave do recebedor conforme atribuído na respectiva PACS008.</term>
    /// </item>
    /// <item>
    /// <term>Os tipos de chave podem ser: telefone, e-mail, cpf/cnpj ou EVP.</term>
    /// </item>
    /// <item>
    /// <term>O formato das chaves pode ser encontrado na seção "Formatação das chaves do DICT no BR Code" do <see href="https://www.bcb.gov.br/estabilidadefinanceira/pix">Manual de Padrões para iniciação do Pix</see>.</term>
    /// </item>
    /// </list>
    /// </remarks>
    public string Chave { get; set; }

    /// <summary>
    /// Horário em que o Pix foi processado no PSP.
    /// </summary>
    public DateTime Horario { get; set; }

    /// <summary>
    /// Informação livre do pagador.
    /// </summary>
    public string? InfoPagador { get; set; }

    /// <summary>
    /// Lista de valores solicitados para devolução.
    /// </summary>
    public List<Devolucao>? Devolucoes { get; set; }
}
