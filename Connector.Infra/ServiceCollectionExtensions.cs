using Connector.Domain.Interfaces.Repositories;
using Connector.Infra.ReadInterfaces;
using Connector.Infra.Repositories;
using Connector.Infra.Repositories.ReadRepositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Connector.Infra
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddInfraDependency(this IServiceCollection services)
        {
            services
                .AddTnfEntityFrameworkCore()    // Configura o uso do EntityFrameworkCore registrando os contextos que serão usados pela aplicação
                .AddMapperDependency();         // Configura o uso do AutoMappper

            // Registro dos repositórios
            services.AddTransient<IConsumoRepository, ConsumoRepository>();
            services.AddTransient<IConsumoReadRepository, ConsumoReadRepository>();

            return services;
        }
    }
}
