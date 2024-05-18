using System.Collections.Generic;

namespace PixDotNet.Models.Common
{
    public class Problema
    {
        /// <summary>
        /// URI de referência que identifica o tipo de problema. De acordo com a RFC 7807.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Descrição resumida do problema.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Código HTTP do status retornado.
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// Descrição completa do problema.
        /// </summary>
        public string Detail { get; set; }

        /// <summary>
        /// Identificador de correlação do problema para fins de suporte.
        /// </summary>
        public string CorrelationId { get; set; }

        /// <summary>
        /// Lista de violações associadas ao problema.
        /// </summary>
        public List<Violacao> Violacoes { get; set; }
    }
}
