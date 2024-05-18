using PixDotNet.Models.Common;
using System.Collections.Generic;
/// <summary>
/// Representa uma lista de Pix consultados.
/// </summary>
public class PixConsultados
{
    /// <summary>
    /// Obtém ou define os parâmetros da consulta Pix.
    /// </summary>
    public ParametrosConsultaPix Parametros { get; set; }

    /// <summary>
    /// Obtém ou define a lista de Pix recebidos.
    /// </summary>
    /// <remarks>
    /// Lista de Pix recebidos.
    /// </remarks>
    public List<Pix> Pix { get; set; }
}
