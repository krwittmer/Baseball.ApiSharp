#region Copyright & OSS License
// Copyright Information
// All source is copyright, Kevin Wittmer
// See License.txt for more information (check Visual Studio Solution Items)
// ==================================
#endregion

using System;
using Baseball.ApiSharp.Dal.EfStructures;
using Baseball.ApiSharp.Dal.Initialization.SampleData;
using Microsoft.EntityFrameworkCore;

namespace Baseball.ApiSharp.Dal.Initialization
{
    public static class SampleDataInitializer
    {
        private static readonly string[] Tables = new[] {
            "AllstarFull", "AwardsShareManagers", "AwardsSharePlayers", "AwardsManagers", "AwardsPlayers",
            "BattingPost", "Batting", "FieldingOFsplit", "FieldingOF", "FieldingPost", "Fielding", "PitchingPost",
            "Managers", "ManagersHalf", "SeriesPost", "Salaries", "HallOfFame", "HomeGames",
            "Parks", "Schools", "Teams", "People" };

        public static void DropAndCreateDatabase(LahmansDbContext context)
        {
            context.Database.EnsureDeleted();
            //This doesn't run the migrations, so SQL objects will be missing
            //DON'T USE THIS => context.Database.EnsureCreated();
            context.Database.Migrate();
        }

        internal static void ResetIdentity(LahmansDbContext context)
        {
            foreach (var table in Tables)
            {
                var rawSqlString = $"DBCC CHECKIDENT (\"{table}\", RESEED, 0);";
#pragma warning disable EF1000 // Possible SQL injection vulnerability.
                context.Database.ExecuteSqlRaw(rawSqlString);
#pragma warning restore EF1000 // Possible SQL injection vulnerability.
            }
        }

        public static void ClearData(LahmansDbContext context)
        {
            foreach (var table in Tables)
            {
                var rawSqlString = $"DELETE FROM \"{table}\";";
#pragma warning disable EF1000 // Possible SQL injection vulnerability.
                context.Database.ExecuteSqlRaw(rawSqlString);
#pragma warning restore EF1000 // Possible SQL injection vulnerability.
            }
            // TODO: Add primary keys or identity columns on all Lahmans DB tables, then uncomment.
            ResetIdentity(context);
        }

        internal static void SeedData(LahmansDbContext context)
        {
            try
            {
                AllTimeBestPlayerData.SeedData(context);
                WhiteSoxGreatsPlayerData.SeedData(context);

                TeamDataChicagoCubs2015.SeedData(context);
                TeamDataOakland2002.SeedData(context); 
                TeamDataChicagoWhiteSox2005.SeedData(context);
                TeamDataDetroitTigers1984.SeedData(context); 
                TeamDataSeattleMariners2001.SeedData(context);

                WinningTeamSampleData.SeedData(context);

                // TODO: bring in other sample data sets (classes)
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
            }
        }

        public static void InitializeExternalDb(LahmansDbContext context)
        {
            //Ensure the database exists and is up to date (migrations)
            context.Database.Migrate();
            ClearData(context);
            SeedData(context);
        }

        public static void InitializeInMemoryDb(LahmansDbContext context)
        {
            SeedData(context);
        }
    }
}
