#region Copyright & OSS License
// Copyright Information
// All source is copyright, Kevin Wittmer
// See License.txt for more information (check Visual Studio Solution Items)
// ==================================
#endregion

using Baseball.ApiSharp.Dal.EfStructures;
using Microsoft.EntityFrameworkCore;

namespace Baseball.ApiSharp.Dal
{
    public class DbContextBuilder
    {
        public LahmansDbContext Build()
        {
            DbContextOptionsBuilder<LahmansDbContext> optionsBuilder = new DbContextOptionsBuilder<LahmansDbContext>();
            CreateDbOptionsBuilder(optionsBuilder);
            DbContextOptions<LahmansDbContext> contextOptions = optionsBuilder.Options;
            return new LahmansDbContext(contextOptions);
        }

        public static void CreateDbOptionsBuilder(DbContextOptionsBuilder optionsBuilder)
        {
            var dbConfig = new EnvironmentDbConfig();
            if (dbConfig.IsSqlServerConnectionStringDefined())
            {
                optionsBuilder.UseSqlServer(dbConfig.GenerateSqlServerConnectionString());
            }
            else if (dbConfig.IsMySqlConnectionStringDefined())
            {
                optionsBuilder.UseMySql(dbConfig.GenerateMySqlConnectionString());
            }
        }
    }
}
