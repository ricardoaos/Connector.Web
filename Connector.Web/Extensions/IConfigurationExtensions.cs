using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Connector.Web.Extensions
{
    public static class IConfigurationExtensions
    {
        public static bool TryGetExternalAuthorityEndpoint(this IConfiguration configuration, out string value)
        {
            var extermalAuthorityEndpoint = configuration["ExternalAuthorityEndpoint"];

            if (!string.IsNullOrWhiteSpace(extermalAuthorityEndpoint))
            {
                value = extermalAuthorityEndpoint;
                return true;
            }

            value = default(string);
            return false;
        }
    }
}
