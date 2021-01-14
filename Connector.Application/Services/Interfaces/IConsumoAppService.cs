using Connector.Dto.Consumo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tnf.Application.Services;
using Tnf.Dto;

namespace Connector.Application.Services.Interfaces
{
    public interface IConsumoAppService : IApplicationService
    {
        Task<IListDto<ConsumoResponseDto>> GetAllConsumoAsync(ConsumoRequestAllDto request);
    }
}
