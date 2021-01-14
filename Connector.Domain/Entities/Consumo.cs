using System;
using Tnf.Notifications;
using Tnf.Repositories.Entities;

namespace Connector.Domain.Entities
{
    public partial class Consumo : IEntity, IMustHaveTenant
    {
        public Guid Id { get; set; }
        public string Description { get; internal set; }
        public float Value { get; internal set; }
        public Guid TenantId { get; set; }

        public static Builder Create(INotificationHandler handler)
            => new Builder(handler);

        public static Builder Create(INotificationHandler handler, Consumo instance)
            => new Builder(handler, instance);

    }
}
