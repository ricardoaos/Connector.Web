﻿using Connector.Infra.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Connector.Web
{
    public class MigrationHostedService : IHostedService
    {
        private readonly IServiceScopeFactory _serviceScopeFactory;

        public MigrationHostedService(IServiceScopeFactory serviceScopeFactory)
        {
            _serviceScopeFactory = serviceScopeFactory;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            using var scope = _serviceScopeFactory.CreateScope();

            var dbContext = scope.ServiceProvider.GetService<CrudDbContext>();

            await dbContext.Database.MigrateAsync();
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
