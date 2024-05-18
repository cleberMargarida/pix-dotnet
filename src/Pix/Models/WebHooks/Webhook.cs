namespace PixDotNet.Models.WebHooks
{
    using System;

    /// <summary>
    /// Representa um webhook completo.
    /// </summary>
    public class Webhook
    {
        /// <summary>
        /// Obtém ou define a URL do webhook.
        /// </summary>
        public string WebhookUrl { get; set; }

        /// <summary>
        /// Obtém ou define a chave DICT do recebedor.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// O campo chave determina a chave Pix registrada no DICT que será utilizada para a cobrança. 
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Os tipos de chave podem ser: telefone, e-mail, cpf/cnpj ou EVP.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// O formato das chaves pode ser encontrado na seção "Formatação das chaves do DICT no BR Code" 
        /// do Manual de Padrões para iniciação do Pix.
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        public string Chave { get; set; }

        /// <summary>
        /// Obtém ou define a data de criação do webhook.
        /// </summary>
        public DateTime Criacao { get; set; }
    }
}
