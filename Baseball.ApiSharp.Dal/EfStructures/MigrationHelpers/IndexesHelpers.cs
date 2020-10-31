#region Copyright & OSS License
// Copyright Information
// All source is copyright, Kevin Wittmer
// See License.txt for more information (check Visual Studio Solution Items)
// ==================================
#endregion

using Microsoft.EntityFrameworkCore.Migrations;

namespace Baseball.ApiSharp.Dal.EfStructures.MigrationHelpers
{
    public class IndexesHelpers
    {
        public static void CreateTableIndexes(MigrationBuilder migrationBuilder)
        {
            // create index batting_pidx on batting(playerID);
            migrationBuilder.CreateIndex("batting_pidx", "batting", "playerID", null, true);

            string sql = @"
                create index people_idx_1 on people(playerID);
                create index batting_idx_1 on batting(yearID, teamID);
                create index pitching_idx_1 on pitching(yearID,teamID);
                create index fielding_idx_1 on fielding(yearID,teamID);
                create index fieldingof_idx_1 on fieldingof(playerID, yearID);
                create index salaries_idx_1 on salaries(playerID);
                create index salaries_idx_2 on salaries(yearID,teamID);

                create index awardsshareplayers_idx on awardsshareplayers(playerID,yearID);
                create index awardsplayers_idx on awardsplayers(playerID,yearID);
            ";
            migrationBuilder.Sql(sql);
        }

        public static void DropTableIndexes(MigrationBuilder migrationBuilder)
        {
            string sql = @"
                drop index batting_pidx on batting;
                drop index people_idx_1 on people;
                drop index batting_idx_1 on batting;
                drop index pitching_idx_1 on pitching;
                drop index fielding_idx_1 on fielding;
                drop index fieldingof_idx_1 on fieldingof_idx_1;
                drop index salaries_idx_1 on salaries;
                drop index salaries_idx_2 on salaries;
                drop index awardsplayers_idx on awardsplayers;
                drop index awardsshareplayers_idx on awardsshareplayers;
            ";
            migrationBuilder.Sql(sql);
        }
    }
}
