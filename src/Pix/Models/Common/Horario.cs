namespace PixDotNet.Models.Common
{
    using System;

    public class Horario
    {
        /// <summary>
        /// Horário de solicitação.
        /// </summary>
        public DateTime Solicitacao { get; set; }

        /// <summary>
        /// Horário de liquidacao.
        /// </summary>
        public DateTime Liquidacao { get; set; }
    }
}