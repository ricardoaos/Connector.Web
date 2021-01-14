using System;
using Microsoft.Extensions.Configuration;

namespace Connector.Infra
{
    public class DatabaseConfiguration
    {
        public DatabaseConfiguration(IConfiguration configuration)
        {
            ConnectionStringName = configuration["DefaultConnectionString"];

            if (DatabaseType.SQLServer.ToString().Equals(ConnectionStringName, StringComparison.CurrentCultureIgnoreCase))
            {
                DatabaseType = DatabaseType.SQLServer;
            }
            else if (DatabaseType.Postgres.ToString().Equals(ConnectionStringName, StringComparison.CurrentCultureIgnoreCase))
            {
                DatabaseType = DatabaseType.Postgres;
            }
            else if (DatabaseType.Sqlite.ToString().Equals(ConnectionStringName, StringComparison.CurrentCultureIgnoreCase))
            {
                DatabaseType = DatabaseType.Sqlite;
            }
            else
                throw new NotSupportedException($"Invalid ConnectionString name '{ConnectionStringName}'.");

            ConnectionString = configuration[$"ConnectionStrings:{ConnectionStringName}"];
        }

        public string ConnectionStringName { get; }
        public string ConnectionString { get; }
        public DatabaseType DatabaseType { get; }
    }

    public enum DatabaseType
    {
        SQLServer,
        Sqlite,
        Postgres        
    }
}
