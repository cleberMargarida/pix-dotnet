namespace PixDotNet.Models.Common
{
    /// <summary>
    /// Enumeração das modalidades de multa.
    /// </summary>
    public enum MultaModalidade
    {
        ValorFixo = 1,
        Percentual = 2
    }

    /// <summary>
    /// Enumeração das modalidades de juros.
    /// </summary>
    public enum JuroModalidade
    {
        ValorDiasCorridos = 1,
        PercentualDiaCorrido = 2,
        PercentualMesCorrido = 3,
        PercentualAnoCorrido = 4,
        ValorDiasUteis = 5,
        PercentualDiaUtil = 6,
        PercentualMesUtil = 7,
        PercentualAnoUtil = 8
    }

    /// <summary>
    /// Enumeração das modalidades de abatimento.
    /// </summary>
    public enum AbatimentoModalidade
    {
        ValorFixo = 1,
        Percentual = 2
    }

    /// <summary>
    /// Enumeração das modalidades de desconto.
    /// </summary>
    public enum DescontoModalidade
    {
        ValorFixoAteDataInformada = 1,
        PercentualAteDataInformada = 2,
        ValorAntecipacaoDiaCorrido = 3,
        ValorAntecipacaoDiaUtil = 4,
        PercentualAntecipacaoDiaCorrido = 5,
        PercentualAntecipacaoDiaUtil = 6
    }

}