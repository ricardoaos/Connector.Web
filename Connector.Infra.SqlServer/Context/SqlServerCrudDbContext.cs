using Connector.Infra.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Tnf.Runtime.Session;

namespace Connector.Infra.SqlServer.Context
{
    public class SqlServerCrudDbContext : CrudDbContext
    {
        public SqlServerCrudDbContext(DbContextOptions<CrudDbContext> options, ITnfSession session)
               : base(options, session)
        {
        }
    }
}
