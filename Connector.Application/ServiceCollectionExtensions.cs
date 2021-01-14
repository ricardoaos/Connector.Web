using Connector.Application.Services;
using Connector.Application.Services.Interfaces;
using Connector.Domain;
using Microsoft.Extensions.DependencyInjection;

namespace Connector.Application
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplicationServiceDependency(this IServiceCollection services)
        {
            // Dependencia do projeto Security.Domain
            services.AddDomainDependency();

            // Para habilitar as convenções do Tnf para Injeção de dependência (ITransientDependency, IScopedDependency, ISingletonDependency)
            // descomente a linha abaixo:
            // services.AddTnfDefaultConventionalRegistrations();

            // Registro dos serviços
            services.AddTransient<IConsumoAppService, ConsumoAppService>();

            return services;
        }
    }
}
