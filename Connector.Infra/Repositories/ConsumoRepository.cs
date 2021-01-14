using Connector.Domain.Entities;
using Connector.Domain.Interfaces.Repositories;
using Connector.Infra.Context;
using System;
using System.Collections.Generic;
using System.Text;
using Tnf.EntityFrameworkCore;
using Tnf.EntityFrameworkCore.Repositories;

namespace Connector.Infra.Repositories
{
    public class ConsumoRepository : EfCoreRepositoryBase<CrudDbContext, Consumo>, IConsumoRepository
    {
        public ConsumoRepository(IDbContextProvider<CrudDbContext> dbContextProvider)
               : base(dbContextProvider)
        {
        }
    }
}
