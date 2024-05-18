using System.Collections.Generic;

namespace PixDotNet.Models.Common
{
    public class CobBase
    {
        /// <summary>
        /// Os campos aninhados sob o identificador calendário organizam informações a respeito de controle de tempo da cobrança.
        /// </summary>
        public Calendario Calendario { get; set; }

        /// <summary>
        /// Os campos aninhados sob o objeto devedor são opcionais e identificam o devedor, ou seja, 
        /// a pessoa ou a instituição a quem a cobrança está endereçada. 
        /// </summary>
        /// <remarks>
        /// Não identifica, necessariamente, 
        /// quem irá efetivamente realizar o pagamento. Um CPF pode ser o devedor de uma cobrança, 
        /// mas pode acontecer de outro CPF realizar, efetivamente, o pagamento do documento. 
        /// Não é permitido que o campo `devedor.cpf` e campo `devedor.cnpj` estejam preenchidos ao mesmo tempo. 
        /// Se o campo `devedor.cnpj` está preenchido, então o campo `devedor.cpf` não pode estar preenchido, e vice-versa. Se o campo `devedor.nome` está preenchido, então deve existir ou um `devedor.cpf` ou um campo `devedor.cnpj` preenchido.
        /// </remarks>
        public DadosDevedor? Devedor { get; set; }

        /// <summary>
        /// Location do Payload.
        /// </summary>
        public PayloadLocation Loc { get; set; }

        /// <summary>
        /// Chave DICT do recebedor.
        /// 
        /// Formato do campo chave:
        /// - O campo chave determina a chave Pix registrada no DICT que será utilizada para a cobrança. 
        /// Essa chave será lida pelo aplicativo do PSP do pagador para consulta ao DICT, que retornará a informação que identificará o recebedor da cobrança.
        /// - Os tipos de chave podem ser: telefone, e-mail, cpf/cnpj ou EVP.
        /// - O formato das chaves pode ser encontrado na seção "Formatação das chaves do DICT no BR Code" do Manual de Padrões para iniciação do Pix.
        /// </summary>
        public string Chave { get; set; }

        /// <summary>
        /// Solicitação ao pagador.
        /// O campo solicitacaoPagador, opcional, determina um texto a ser apresentado ao pagador para que ele possa digitar uma informação correlata, em formato livre, a ser enviada ao recebedor. 
        /// Esse texto será preenchido, na pacs.008, pelo PSP do pagador, no campo RemittanceInformation <c>RmtInf</c>. 
        /// O tamanho do campo <c>RmtInf</c> na pacs.008 está limitado a 140 caracteres.
        /// </summary>
        public string? SolicitacaoPagador { get; set; }

        /// <summary>
        /// Informações adicionais.
        /// Cada respectiva informação adicional contida na lista (nome e valor) deve ser apresentada ao pagador.
        /// </summary>
        public List<InformacaoAdicional> InfoAdicionais { get; set; }
    }
}