#region Copyright & OSS License
// Copyright Information
// All source is copyright, Kevin Wittmer
// See License.txt for more information (check Visual Studio Solution Items)
// ==================================
#endregion

using Microsoft.EntityFrameworkCore.Migrations;

namespace Baseball.ApiSharp.Dal.EfStructures.MigrationHelpers
{
    public class TablesHelper
    {
        public static void CreateRichJsonTagDataTable(MigrationBuilder migrationBuilder)
        {
            /*
            */
            string sql = @"
                create table RichJsonTagData (
                    tag_id INT NOT NULL,
                    tag_rich_detail JSON,
                    created_at DATETIME
                );
            ";
            migrationBuilder.Sql(sql);
        }

        public static void DropRichJsonTagDataTable(MigrationBuilder migrationBuilder)
        {
            /*
            */
            string sql = @"
                drop table RichJsonTagData;
            ";
            migrationBuilder.Sql(sql);
        }

    }
}
