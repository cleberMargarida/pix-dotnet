namespace PixDotNet.Models.Common
{
    /// <summary>
    /// Pessoa Jurídica.
    /// </summary>
    public class PessoaJuridica : DadosDevedor
    {
        /// <summary>
        /// Cpf do usuário.
        /// </summary>
        public string Cnpj { get; set; }
    }
}
