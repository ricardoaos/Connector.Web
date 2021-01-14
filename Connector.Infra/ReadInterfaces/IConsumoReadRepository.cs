using Connector.Dto.Consumo;
using System.Threading.Tasks;
using Tnf.Dto;
using Tnf.Repositories;

namespace Connector.Infra.ReadInterfaces
{
    public interface IConsumoReadRepository : IRepository
    {
        Task<IListDto<ConsumoResponseDto>> GetAllConsumoAsync(ConsumoRequestAllDto key);
    }
}
