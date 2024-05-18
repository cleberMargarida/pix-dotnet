namespace PixDotNet.Models.Common
{
    public class Devolucao
    {
        /// <summary>
        /// Id gerado pelo cliente para representar unicamente uma devolução.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// ReturnIdentification que transita na PACS004.
        /// </summary>
        public string RtrId { get; set; }

        /// <summary>
        /// Valor a devolver.
        /// </summary>
        public decimal Valor { get; set; }

        /// <summary>
        /// Horário no qual a devolução foi solicitada/liquidada no PSP.
        /// </summary>
        public Horario Horario { get; set; }

        /// <summary>
        /// Status da devolução.
        /// </summary>
        /// <remarks>
        /// Campo opcional que pode ser utilizado pelo PSP recebedor para detalhar os motivos
        /// de a devolução ter atingido o status em questão.
        /// Pode ser utilizado, por exemplo, para detalhar o motivo de a devolução não ter sido realizada.
        /// </remarks>
        public DevolucaoStatus? Status { get; set; }

        /// <summary>
        /// Natureza da Devolução.
        /// </summary>
        /// <remarks>
        /// Indica qual é a natureza da devolução. Uma devolução pode ser relacionada a um Pix comum (com códigos possíveis: `MD06`, `BE08` e `FR01` da pacs.004), 
        /// ou a um Pix de Saque ou Troco (com códigos possíveis:  `MD06` e `SL02` da pacs.004). Na ausência deste campo a natureza deve ser interpretada como 
        /// sendo de um Pix comum (`ORIGINAL`).
        ///
        /// As naturezas são assim definidas:
        /// <list type="bullet">
        ///     <item>
        ///         <description>`ORIGINAL`: quando a devolução é solicitada pelo usuário recebedor e se refere a um Pix comum ou ao valor da compra em um Pix Troco (`MD06`);</description>
        ///     </item>
        ///     <item>
        ///         <description>`RETIRADA`: quando a devolução é solicitada pelo usuário recebedor e se refere a um Pix Saque ou ao valor do troco em um Pix Troco (`SL02`);</description>
        ///     </item>
        ///     <item>
        ///         <description>`MED_OPERACIONAL`: quando a devolução ocorre no âmbito do MED por motivo de falha operacional e se refere a um Pix comum (`BE08`);</description>
        ///     </item>
        ///     <item>
        ///         <description>`MED_FRAUDE`: quando a devolução ocorre no âmbito do MED por fundada suspeita de fraude e se refere a um Pix comum (`FR01`);</description>
        ///     </item>
        /// </list>
        ///
        /// Os valores de devoluções são sempre limitados aos valores máximos a seguir:
        /// <list type="bullet">
        ///     <item>
        ///         <description>Pix comum: o valor da devolução é limitado ao valor do próprio Pix (a natureza nesse caso pode ser: ORIGINAL, MED_OPERACIONAL ou MED_FRAUDE);</description>
        ///     </item>
        ///     <item>
        ///         <description>Pix Saque: o valor da devolução é limitado ao valor da retirada (a natureza nesse caso deve ser: RETIRADA);</description>
        ///     </item>
        ///     <item>
        ///         <description>Pix Troco: o valor da devolução é limitado ao valor relativo à compra ou ao troco:
        ///             <list type="bullet">
        ///                 <item>
        ///                     <description>Quando a devolução for referente à compra, o valor limita-se ao valor da compra (a natureza nesse caso deve ser ORIGINAL);</description>
        ///                 </item>
        ///                 <item>
        ///                     <description>Quando a devolução for referente ao troco, o valor limita-se ao valor do troco (a natureza nesse caso deve ser RETIRADA).</description>
        ///                 </item>
        ///             </list>
        ///         </description>
        ///     </item>
        /// </list>
        /// </remarks>
        public string? Natureza { get; set; }

        /// <summary>
        /// Mensagem ao pagador relativa à devolução.
        /// </summary>
        /// <remarks>
        /// O campo `descricao`, opcional, determina um texto a ser apresentado ao pagador
        /// contendo informações sobre a devolução. Esse texto será preenchido, na pacs.004, 
        /// pelo PSP do recebedor, no campo RemittanceInformation. 
        /// O tamanho do campo na pacs.004 está limitado a 140 caracteres.
        /// </remarks>
        public string? Descricao { get; set; }

        /// <summary>
        /// Descrição do status.
        /// </summary>
        /// <remarks>
        /// Campo opcional que pode ser utilizado pelo PSP recebedor para detalhar os motivos
        /// de a devolução ter atingido o status em questão.
        /// Pode ser utilizado, por exemplo, para detalhar o motivo de a devolução não ter sido realizada.
        /// O tamanho do campo está limitado a 140 caracteres.
        /// </remarks>
        public string? Motivo { get; set; }
    }
}