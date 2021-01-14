﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Connector.Domain
{
    public static class TnfConfigurationExtensions
    {
        public static void UseDomainLocalization(this ITnfBuilder builder)
        {
            builder.Localization(localization =>
            {
                // Incluindo o source de localização
                localization.AddJsonEmbeddedLocalizationFile(
                    Constants.LocalizationSourceName,
                    typeof(Constants).Assembly,
                    "Connector.Domain.Localization.SourceFiles");

                // Incluindo suporte as seguintes linguagens
                localization.AddLanguage("pt-BR", "Português", isDefault: true);
                localization.AddLanguage("en", "English");
            });

        }
    }
}
