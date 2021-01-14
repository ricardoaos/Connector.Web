using Connector.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Connector.Infra.Context.Builders
{
    public class ConsumoTypeConfiguration : IEntityTypeConfiguration<Consumo>
    {
        public void Configure(EntityTypeBuilder<Consumo> builder)
        {
            builder.ToTable("Products");

            builder.HasKey(k => k.Id);
            builder.Property(p => p.Description).IsRequired();
            builder.Property(p => p.Value).IsRequired();
        }
    }
}
