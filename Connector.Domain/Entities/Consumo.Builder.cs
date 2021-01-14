using Connector.Domain.Entities.Specifications;
using System;
using Tnf.Builder;
using Tnf.Notifications;

namespace Connector.Domain.Entities
{
    public partial class Consumo
    {
        public class Builder : Builder<Consumo>
        {
            public Builder(INotificationHandler notificationHandler)
                : base(notificationHandler)
            {
            }

            public Builder(INotificationHandler notificationHandler, Consumo instance)
                : base(notificationHandler, instance)
            {
            }

            public Builder WithId(Guid id)
            {
                Instance.Id = id;
                return this;
            }

            public Builder WithDescription(string description)
            {
                Instance.Description = description;
                return this;
            }

            public Builder WithValue(float value)
            {
                Instance.Value = value;
                return this;
            }

            protected override void Specifications()
            {
                AddSpecification<ConsumoShouldHaveDescriptionSpecification>();
                AddSpecification<ConsumoShouldHaveValueSpecification>();
            }
        }
    }
}
