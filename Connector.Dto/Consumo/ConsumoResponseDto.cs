using System;
using System.Collections.Generic;
using System.Text;

namespace Connector.Dto.Consumo
{
    public class ConsumoResponseDto
    {
        public Guid Id { get; set; }
        public string DescricaoTipoTicket { get; set; }
        public int Qtd { get; set; }
        public int QuantidadeItens { get; set; }
        public int Tamanho { get; set; }
        public int Tempo { get; set; }
    }
}
