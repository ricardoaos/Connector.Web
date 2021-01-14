using Connector.Infra.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Tnf.Runtime.Session;

namespace Connector.Infra.SqlServer.Context
{
    public class SqlServerCrudDbContextFactory //: IDesignTimeDbContextFactory<SqlServerCrudDbContext>
    {
        public SqlServerCrudDbContextFactory CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<CrudDbContext>();

            var configuration = new ConfigurationBuilder()
                                    .SetBasePath(Directory.GetCurrentDirectory())
                                    .AddJsonFile($"appsettings.Development.json", false)
                                    .Build();

            var databaseConfiguration = new DatabaseConfiguration(configuration);

            builder.UseSqlServer(databaseConfiguration.ConnectionString);

            return null;//new SqlServerCrudDbContext(builder.Options, NullTnfSession.Instance);
        }
    }
}
