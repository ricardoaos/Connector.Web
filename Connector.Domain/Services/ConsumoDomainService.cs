using Connector.Domain.Interfaces.Repositories;
using Connector.Domain.Interfaces.Services;
using Tnf.Domain.Services;
using Tnf.Notifications;

namespace Connector.Domain.Services
{
    public class ConsumoDomainService : DomainService, IConsumoDomainService
    {
        private readonly IConsumoRepository _repository;

        public ConsumoDomainService(IConsumoRepository repository, INotificationHandler notificationHandler)
            : base(notificationHandler)
        {
            _repository = repository;
        }
    }
}
