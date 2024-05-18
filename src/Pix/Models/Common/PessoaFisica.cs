using System;
using System.Collections.Generic;
using System.Text;

namespace PixDotNet.Models.Common
{
    /// <summary>
    /// Pessoa Física.
    /// </summary>
    public class PessoaFisica : DadosDevedor
    {
        /// <summary>
        /// Cpf do usuário.
        /// </summary>
        public string Cpf { get; set; }
    }
}
