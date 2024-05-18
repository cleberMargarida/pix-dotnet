
/// <summary>
/// Representa os componentes do valor de um Pix.
/// </summary>
public class ComponentesValor
{
    /// <summary>
    /// Obtém ou define o valor original do Pix.
    /// </summary>
    public PixValor? Original { get; set; }

    /// <summary>
    /// Obtém ou define os detalhes do saque do Pix.
    /// </summary>
    public PixValorDetalhado? Saque { get; set; }

    /// <summary>
    /// Obtém ou define o valor do troco do Pix.
    /// </summary>
    public PixValorDetalhado? Troco { get; set; }

    /// <summary>
    /// Obtém ou define os detalhes dos juros do Pix.
    /// </summary>
    public PixValor? Juros { get; set; }

    /// <summary>
    /// Obtém ou define os detalhes da multa do Pix.
    /// </summary>
    public PixValor? Multa { get; set; }

    /// <summary>
    /// Obtém ou define os detalhes do abatimento do Pix.
    /// </summary>
    public PixValor? Abatimento { get; set; }

    /// <summary>
    /// Obtém ou define os detalhes do desconto do Pix.
    /// </summary>
    public PixValor? Desconto { get; set; }
}
