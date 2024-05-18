namespace PixDotNet.Models.Cob
{
    /// <summary>
    /// Estado do registro da cobrança.
    /// Não se confunde com o estado da cobrança em si, ou seja, não guarda relação com o fato de a cobrança encontrar-se vencida ou expirada, por exemplo.
    /// </summary>
    public enum CobrancaStatus
    {
        /// <summary>
        /// Indica que o registro se refere a uma cobrança que foi gerada mas ainda não foi paga nem removida.
        /// </summary>
        ATIVA,

        /// <summary>
        /// Indica que o registro se refere a uma cobrança que já foi paga e, por conseguinte, não pode acolher outro pagamento.
        /// </summary>
        CONCLUIDA,

        /// <summary>
        /// Indica que o usuário recebedor solicitou a remoção do registro da cobrança.
        /// </summary>
        REMOVIDA_PELO_USUARIO_RECEBEDOR,

        /// <summary>
        /// Indica que o PSP Recebedor solicitou a remoção do registro da cobrança.
        /// </summary>
        REMOVIDA_PELO_PSP
    }

}