using Connector.Domain;
using Connector.Infra.Context;
using Connector.Infra.SqlServer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Connector.Infra.SqlServer
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddSqLiteDependency(this IServiceCollection services)
        {
            services
                .AddInfraDependency()
                .AddTnfDbContext<CrudDbContext, SqlServerCrudDbContext>((config) =>
                {
                    if (Constants.IsDevelopment())
                    {
                        config.DbContextOptions.EnableSensitiveDataLogging();
                        config.DbContextOptions.ConfigureWarnings(warnings => warnings.Throw(RelationalEventId.QueryClientEvaluationWarning));
                        config.UseLoggerFactory();
                    }

                    if (config.ExistingConnection != null)
                        config.DbContextOptions.UseSqlServer(config.ExistingConnection);
                    else
                        config.DbContextOptions.UseSqlServer(config.ConnectionString);
                });

            return services;
        }
    }
}
