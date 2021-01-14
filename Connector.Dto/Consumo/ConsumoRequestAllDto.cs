using System;
using System.Collections.Generic;
using System.Text;
using Tnf.Dto;

namespace Connector.Dto.Consumo
{
    public class ConsumoRequestAllDto : RequestAllDto
    {
        public string CodigoSistemaSatelite { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
    }
}
