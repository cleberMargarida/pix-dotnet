using System.Collections.Generic;

namespace PixDotNet.Models.Common
{
    public class PayloadLocationConsultadas
    {
        public ParametrosConsultaPayloadLocation Parametros { get; set; }
        public List<PayloadLocation> Loc { get; set; }
    }
}
