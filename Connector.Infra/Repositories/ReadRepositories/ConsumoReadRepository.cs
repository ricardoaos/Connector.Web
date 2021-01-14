using Connector.Domain.Entities;
using Connector.Dto.Consumo;
using Connector.Infra.Context;
using Connector.Infra.ReadInterfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tnf.Dto;
using Tnf.EntityFrameworkCore;
using Tnf.EntityFrameworkCore.Repositories;

namespace Connector.Infra.Repositories.ReadRepositories
{
    public class ConsumoReadRepository : EfCoreRepositoryBase<CrudDbContext, Consumo>, IConsumoReadRepository
    {
        public ConsumoReadRepository(IDbContextProvider<CrudDbContext> dbContextProvider)
               : base(dbContextProvider)
        {
        }

        public async Task<IListDto<ConsumoResponseDto>> GetAllConsumoAsync(ConsumoRequestAllDto key)
            => await GetAllAsync<ConsumoResponseDto>(key, p => key.CodigoSistemaSatelite.IsNullOrEmpty() || p.Description.Contains(key.CodigoSistemaSatelite));

    }
}
