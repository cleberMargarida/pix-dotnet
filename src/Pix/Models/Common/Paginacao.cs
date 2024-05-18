namespace PixDotNet.Models.Common
{
    public class Paginacao
    {
        /// <summary>
        /// Número da página recuperada.
        /// </summary>
        /// <remarks>
        /// A página atual deve ser maior ou igual a 0.
        /// </remarks>
        public int PaginaAtual { get; set; }

        /// <summary>
        /// Quantidade de registros retornado na página.
        /// </summary>
        /// <remarks>
        /// A quantidade de itens por página deve ser maior ou igual a 1.
        /// </remarks>
        public int ItensPorPagina { get; set; }

        /// <summary>
        /// Quantidade de páginas disponíveis para consulta.
        /// </summary>
        /// <remarks>
        /// A quantidade de páginas deve ser maior ou igual a 1.
        /// </remarks>
        public int QuantidadeDePaginas { get; set; }

        /// <summary>
        /// Quantidade total de itens disponíveis de acordo com os parâmetros informados.
        /// </summary>
        /// <remarks>
        /// A quantidade total de itens deve ser maior ou igual a 0.
        /// </remarks>
        public int QuantidadeTotalDeItens { get; set; }
    }

}
