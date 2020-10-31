using System;
using Baseball.ApiSharp.Dal.EfStructures.MigrationHelpers;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Baseball.ApiSharp.Dal.EfStructures.Migrations
{
    public partial class IAT : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            Console.WriteLine($"Microsoft SQL Server flag: {migrationBuilder.IsSqlServer()}. If 'false' then logic defaults to MySQL DB provider.");
            Console.WriteLine("Applying Entity Framework Core create migrations to extend Lahman schema.");

            migrationBuilder.CreateTable(
                name: "TagRelationships",
                columns: table => new
                {
                    TagRelationshipId = table.Column<string>(maxLength: 64, nullable: false),
                    DataEntityId = table.Column<string>(maxLength: 64, nullable: true),
                    TagId = table.Column<string>(maxLength: 64, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TagRelationships", x => x.TagRelationshipId);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    TagId = table.Column<string>(maxLength: 64, nullable: false),
                    TagValue = table.Column<string>(maxLength: 512, nullable: true),
                    DataFieldReferencesAsJson = table.Column<string>(maxLength: 1024, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.TagId);
                });

            TablesHelper.CreateRichJsonTagDataTable(migrationBuilder);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TagRelationships");

            migrationBuilder.DropTable(
                name: "Tags");

            TablesHelper.DropRichJsonTagDataTable(migrationBuilder);

        }
    }
}