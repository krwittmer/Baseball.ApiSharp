#region Copyright & OSS License
// Copyright Information
// All source is copyright, Kevin Wittmer
// See License.txt for more information (check Visual Studio Solution Items)
// ==================================
#endregion

using System;
using Baseball.ApiSharp.Dal.EfStructures;
using Microsoft.EntityFrameworkCore;

namespace Baseball.ApiSharp.Dal.Tests
{
    public class TestContextHelper
    {
        public TestContextHelper() : this(string.Concat("inMemDb-", RandomNumberHelper.NextInteger(), " (",
            nameof(TestContextHelper), ')'))
        {
        }

        public TestContextHelper(string environmentClass)
        {
            var optionsBuilder = new DbContextOptionsBuilder<LahmansDbContext>();
            if (!string.IsNullOrEmpty(environmentClass) && environmentClass.ToLower().Contains("test"))
            {
                optionsBuilder.UseInMemoryDatabase(environmentClass);
            }
            else
            {
                var envConfig = new EnvironmentDbConfig();
                var connectionString = envConfig.ToString();
                if (envConfig.IsSqlServerConnectionStringDefined())
                {
                    optionsBuilder.UseSqlServer(connectionString);

                }
                else if (envConfig.IsMySqlConnectionStringDefined())
                {
                    optionsBuilder.UseMySql(connectionString);
                }
                else
                {
                    throw new ApplicationException("Could not identify database driver based on DB connection string.");
                }
            }

            Options = optionsBuilder.Options;
        }

        public DbContextOptions<LahmansDbContext> Options { get; }
    }
}
