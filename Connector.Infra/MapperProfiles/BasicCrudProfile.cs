using AutoMapper;
using Connector.Domain.Entities;
using Connector.Dto.Consumo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Connector.Infra.MapperProfiles
{
    public class BasicCrudProfile : Profile
    {
        public BasicCrudProfile()
        {
            CreateMap<Consumo, ConsumoDto>();
            CreateMap<Consumo, ConsumoResponseDto>();
        }
    }
}
