using Connector.Application.Services.Interfaces;
using Connector.Domain.Interfaces.Services;
using Connector.Dto.Consumo;
using Connector.Infra.ReadInterfaces;
using System.Threading.Tasks;
using Tnf.Application.Services;
using Tnf.Dto;
using Tnf.Notifications;

namespace Connector.Application.Services
{
    public class ConsumoAppService : ApplicationService, IConsumoAppService
    {
        private readonly IConsumoDomainService _domainService;
        private readonly IConsumoReadRepository _readRepository;

        public ConsumoAppService(IConsumoDomainService domainService, IConsumoReadRepository readRepository, INotificationHandler notificationHandler)
            : base(notificationHandler)
        {
            _domainService = domainService;
            _readRepository = readRepository;
        }

        public async Task<IListDto<ConsumoResponseDto>> GetAllConsumoAsync(ConsumoRequestAllDto request)
            => await _readRepository.GetAllConsumoAsync(request);
    }
}
