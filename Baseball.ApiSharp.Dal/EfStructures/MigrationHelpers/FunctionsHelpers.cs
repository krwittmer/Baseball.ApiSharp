#region Copyright & OSS License
// Copyright Information
// All source is copyright, Kevin Wittmer
// See License.txt for more information (check Visual Studio Solution Items)
// ==================================
#endregion

using Microsoft.EntityFrameworkCore.Migrations;

namespace Baseball.ApiSharp.Dal.EfStructures.MigrationHelpers
{
    public static class FunctionsHelper
    {
        public static void CreateRichTagDateFunction(MigrationBuilder migrationBuilder)
        {
            /*
            string sql = @"
    CREATE FUNCTION GetJsonTagDate(@TagId INT)
    RETURNS DATETIME WITH SCHEMABINDING 
    BEGIN 
      SELECT @Result = created_at FROM richjsontagdata 
      WHERE TagId = @TagId; 
      RETURN @Result 
    END";
            migrationBuilder.Sql(sql);
            */
        }
        public static void DropRichTagDateFunction(MigrationBuilder builder)
        {
            /*
            builder.Sql("drop function GetJsonTagDate");
            */
        }

    }
}
