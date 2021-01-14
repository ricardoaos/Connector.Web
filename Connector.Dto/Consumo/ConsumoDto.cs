using System;
using System.Collections.Generic;
using System.Text;
using Tnf.Dto;

namespace Connector.Dto.Consumo
{
    public class ConsumoDto : BaseDto
    {
        public Guid Id { get; set; }

        public string Description { get; set; }

        public float Value { get; set; }
    }
}
