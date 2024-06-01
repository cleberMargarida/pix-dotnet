using System;
using System.Collections.Generic;
using System.Text;

namespace PixDotNet.Models.Common
{
    internal class ValorPayload
    {
        public ValorPayload()
        {
            
        }

        public ValorPayload(decimal valor)
        {
            Valor = valor;
        }

        public decimal Valor { get; set; }
    }
}
