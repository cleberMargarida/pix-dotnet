namespace PixDotNet.Models.Common
{
    /// <summary>
    /// Parâmetros de Consulta Pix.
    /// </summary>
    public class ParametrosConsultaPix
    {
        /// <summary>
        /// Data de Início. Respeita RFC 3339.
        /// </summary>
        public string Inicio { get; set; }

        /// <summary>
        /// Data de Fim. Respeita RFC 3339.
        /// </summary>
        public string Fim { get; set; }

        /// <summary>
        /// TxId. Deve ter entre 1 e 35 caracteres alfanuméricos.
        /// </summary>
        public string? Txid { get; set; }

        /// <summary>
        /// Filtro pela existência de txid.
        /// </summary>
        public bool TxIdPresente { get; set; }

        /// <summary>
        /// Filtro pela existência de devolução.
        /// </summary>
        public bool DevolucaoPresente { get; set; }

        /// <summary>
        /// CPF.
        /// </summary>
        public string? Cpf { get; set; }

        /// <summary>
        /// CNPJ.
        /// </summary>
        public string? Cnpj { get; set; }

        /// <summary>
        /// Paginação.
        /// </summary>
        public Paginacao Paginacao { get; set; }
    }
}
