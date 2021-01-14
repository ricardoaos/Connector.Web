using Connector.Infra.MapperProfiles;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Connector.Infra
{
    public static class MapperExtensions
    {
        public static IServiceCollection AddMapperDependency(this IServiceCollection services)
        {
            // Configura o uso do AutoMappper
            return services.AddTnfAutoMapper(config =>
            {
                config.AddProfile<BasicCrudProfile>();
            });
        }
    }
}
