using Microsoft.EntityFrameworkCore.Migrations;

namespace Hyked.API.Migrations
{
    public partial class DefaultDbSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "17114131");

            migrationBuilder.RenameTable(
                name: "PointsOfInterest",
                newName: "PointsOfInterest",
                newSchema: "17114131");

            migrationBuilder.RenameTable(
                name: "Cities",
                newName: "Cities",
                newSchema: "17114131");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "PointsOfInterest",
                schema: "17114131",
                newName: "PointsOfInterest");

            migrationBuilder.RenameTable(
                name: "Cities",
                schema: "17114131",
                newName: "Cities");
        }
    }
}
