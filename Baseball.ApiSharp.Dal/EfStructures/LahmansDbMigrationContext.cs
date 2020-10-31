#region Copyright & OSS License
// Copyright Information
// All source is copyright, Kevin Wittmer
// See License.txt for more information (check Visual Studio Solution Items)
// ==================================
#endregion

using Microsoft.EntityFrameworkCore;

namespace Baseball.ApiSharp.Dal.EfStructures
{
    public class LahmansDbMigrationContext : LahmansDbContext
    {
        /**
         * Base MySQL command series:
         *
         * cd \MySQL\bin
         * mysql -h localhost -u root -p
         *
         * drop database lahmans2019db;
         * (exit)
         *
         * mysql -h localhost -u dbuser -p < "\Lahmans DB Import\lahman2019-mysql-dump.sql"
         *
         * Consider EF Migration commands, and work from this subdirectory:
         *   \Source\repos\Baseball.ApiSharp\Baseball.ApiSharp.Dal
         *
         * Execute this EF command:
         *   dotnet ef migrations add IAT -o EfStructures\Migrations -c Baseball.ApiSharp.Dal.EfStructures.LahmansDbMigrationContext
         *
         * Later, execute this EF command:
         *   dotnet ef database update -c Baseball.ApiSharp.Dal.EfStructures.LahmansDbMigrationContext
         *
         * Also, keep in mind this C# source change/revision:
         *   optionsBuilder.UseMySql(@"server=dbserver;database=Lahmans2019DB;uid=dbuser;pwd=dbp@ssw0RD");
         *
         * Finally, remember C# files generated in Migrations folder are generally transient.
         *
         * TODO: Copy and summarize the above in a MD file capturing these key details and commands.
         */

        /**
         * Default constructor needed for EF Core migration add step.  
         */
        public LahmansDbMigrationContext() : base(new DbContextOptions<LahmansDbContext>())
        {
        }
    }
}
