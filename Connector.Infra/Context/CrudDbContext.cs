using Connector.Domain.Entities;
using Connector.Infra.Context.Builders;
using Microsoft.EntityFrameworkCore;
using Tnf.EntityFrameworkCore;
using Tnf.Runtime.Session;

namespace Connector.Infra.Context
{
    public abstract class CrudDbContext : TnfDbContext
    {
        public DbSet<Consumo> Products { get; set; }

        public CrudDbContext(DbContextOptions<CrudDbContext> options, ITnfSession session)
            : base(options, session)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ConsumoTypeConfiguration());
        }
    }
}
