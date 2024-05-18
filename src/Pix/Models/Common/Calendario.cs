namespace PixDotNet.Models.Common
{
    using System;

    public class Calendario
    {
        /// <summary>
        /// Timestamp que indica o momento em que foi criada a cobrança. Respeita o formato definido na RFC 3339.
        /// </summary>
        public DateTime Criacao { get; set; }

        /// <summary>
        /// Timestamp que indica o momento em que o payload JSON que representa a cobrança foi recuperado. Ou seja, idealmente, é o momento em que o usuário realizou a captura do QR Code para verificar os dados de pagamento. Respeita o formato definido na RFC 3339.
        /// </summary>
        public DateTime Apresentacao { get; set; }

        /// <summary>
        /// Tempo de vida da cobrança, especificado em segundos a partir da data de criação (Calendario.criacao).
        /// </summary>
        public long Expiracao { get; set; }

        /// <summary>
        /// Trata-se de uma data, no formato `YYYY-MM-DD`, segundo ISO 8601. É a data de vencimento da cobrança. A cobrança pode ser honrada até esse dia, inclusive, em qualquer horário do dia.
        /// </summary>
        public DateTime DataDeVencimento { get; set; }

        /// <summary>
        /// Quantidade de dias corridos após a data de vencimento em que a cobrança poderá ser paga.
        /// </summary>
        /// <remarks>
        /// Trata-se da quantidade de dias corridos após <c>calendario.dataDeVencimento</c>, em que a cobrança poderá ser paga.
        /// <br></br>
        /// <br></br>
        /// Sempre que a data de vencimento cair em um fim de semana ou em um feriado para o usuário pagador,
        /// ela deve ser automaticamente prorrogada para o primeiro dia útil subsequente. Todos os campos 
        /// que façam referência a esta data (<c>validadeAposVencimento</c>, <c>desconto</c>, <c>juros</c> e <c>multa</c>) devem assumir 
        /// essa prorrogação, quando for o caso.
        /// <br></br>
        /// <br></br>
        /// Para ilustrar o funcionamento, seguem alguns exemplos, onde:
        /// <list type="bullet">
        ///     <listheader>
        ///         <term>Term</term>
        ///         <description>Description</description>
        ///     </listheader>
        ///     <item>
        ///         <term><c>(#)</c></term>
        ///         <description>representa a data de vencimento;</description>
        ///     </item>
        ///     <item>
        ///         <term><c>(*)</c></term>
        ///         <description>representa a data ajustada em função de dias não úteis;</description>
        ///     </item>
        ///     <item>
        ///         <term><c>(número)</c></term>
        ///         <description>correspondem aos dias adicionais de validade para o pagamento.</description>
        ///     </item>
        /// </list>
        /// </remarks>
        public long ValidadeAposVencimento { get; set; }
    }
}