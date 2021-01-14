using System;
using System.Linq.Expressions;
using Tnf.Specifications;

namespace Connector.Domain.Entities.Specifications
{
    public class ConsumoShouldHaveValueSpecification : Specification<Consumo>
    {
        public override string LocalizationSource { get; protected set; } = Constants.LocalizationSourceName;
        public override Enum LocalizationKey { get; protected set; } = Consumo.Error.ConsumoShouldHaveValue;

        public override Expression<Func<Consumo, bool>> ToExpression()
        {
            return (p) => p.Value != 0;
        }
    }
}
