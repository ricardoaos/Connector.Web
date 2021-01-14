using System;
using System.Collections.Generic;
using System.Text;

namespace Connector.Domain.Entities
{
    public interface IEntity
    {
        Guid Id { get; set; }
    }
}
