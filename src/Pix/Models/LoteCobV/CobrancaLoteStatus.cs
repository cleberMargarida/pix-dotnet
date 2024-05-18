namespace PixDotNet.Models.LoteCobV
{
    /// <summary>
    /// Representa o status de uma solicitação de criação/alteração de cobrança no contexto de um lote.
    /// </summary>
    public enum CobrancaLoteStatus
    {
        /// <summary>
        /// A solicitação está em processamento.
        /// </summary>
        EM_PROCESSAMENTO,

        /// <summary>
        /// A solicitação foi criada com sucesso.
        /// </summary>
        CRIADA,

        /// <summary>
        /// A solicitação foi negada.
        /// </summary>
        NEGADA
    }
}
