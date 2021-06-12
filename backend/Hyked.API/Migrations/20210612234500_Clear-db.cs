using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hyked.API.Migrations
{
    public partial class Cleardb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PointsOfInterest",
                schema: "17114131");

            migrationBuilder.DropTable(
                name: "Cities",
                schema: "17114131");

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 23, 44, 59, 439, DateTimeKind.Unspecified).AddTicks(8436), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 23, 44, 59, 439, DateTimeKind.Unspecified).AddTicks(9114), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 23, 44, 59, 439, DateTimeKind.Unspecified).AddTicks(9122), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Trips",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DepartureTimeUtc", "LastModifiedUtc" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 12, 23, 44, 59, 440, DateTimeKind.Unspecified).AddTicks(3585), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 6, 12, 23, 44, 59, 440, DateTimeKind.Unspecified).AddTicks(5862), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Trips",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DepartureTimeUtc", "LastModifiedUtc" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 12, 23, 44, 59, 440, DateTimeKind.Unspecified).AddTicks(6495), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 6, 12, 23, 44, 59, 440, DateTimeKind.Unspecified).AddTicks(6497), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Trips",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DepartureTimeUtc", "LastModifiedUtc" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 12, 23, 44, 59, 440, DateTimeKind.Unspecified).AddTicks(6501), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 6, 12, 23, 44, 59, 440, DateTimeKind.Unspecified).AddTicks(6503), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Trips",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DepartureTimeUtc", "LastModifiedUtc" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 12, 23, 44, 59, 440, DateTimeKind.Unspecified).AddTicks(6506), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 6, 12, 23, 44, 59, 440, DateTimeKind.Unspecified).AddTicks(6507), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 23, 44, 59, 437, DateTimeKind.Unspecified).AddTicks(6249), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 23, 44, 59, 437, DateTimeKind.Unspecified).AddTicks(7020), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 23, 44, 59, 437, DateTimeKind.Unspecified).AddTicks(7029), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 23, 44, 59, 437, DateTimeKind.Unspecified).AddTicks(7032), new TimeSpan(0, 0, 0, 0, 0)));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cities",
                schema: "17114131",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PointsOfInterest",
                schema: "17114131",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PointsOfInterest", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PointsOfInterest_Cities_CityId",
                        column: x => x.CityId,
                        principalSchema: "17114131",
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 23, 5, 34, 395, DateTimeKind.Unspecified).AddTicks(9973), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 23, 5, 34, 396, DateTimeKind.Unspecified).AddTicks(689), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 23, 5, 34, 396, DateTimeKind.Unspecified).AddTicks(699), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.InsertData(
                schema: "17114131",
                table: "Cities",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "The one where Spidey swings", "New York City" },
                    { 2, "The one where Levski was born", "Karlovo" },
                    { 3, "The one with the artsy stuff", "Paris" }
                });

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Trips",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DepartureTimeUtc", "LastModifiedUtc" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 12, 23, 5, 34, 396, DateTimeKind.Unspecified).AddTicks(5772), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 6, 12, 23, 5, 34, 396, DateTimeKind.Unspecified).AddTicks(8340), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Trips",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DepartureTimeUtc", "LastModifiedUtc" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 12, 23, 5, 34, 396, DateTimeKind.Unspecified).AddTicks(9038), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 6, 12, 23, 5, 34, 396, DateTimeKind.Unspecified).AddTicks(9041), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Trips",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DepartureTimeUtc", "LastModifiedUtc" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 12, 23, 5, 34, 396, DateTimeKind.Unspecified).AddTicks(9045), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 6, 12, 23, 5, 34, 396, DateTimeKind.Unspecified).AddTicks(9047), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Trips",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DepartureTimeUtc", "LastModifiedUtc" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 12, 23, 5, 34, 396, DateTimeKind.Unspecified).AddTicks(9050), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 6, 12, 23, 5, 34, 396, DateTimeKind.Unspecified).AddTicks(9052), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 23, 5, 34, 395, DateTimeKind.Unspecified).AddTicks(3590), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 23, 5, 34, 395, DateTimeKind.Unspecified).AddTicks(4397), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 23, 5, 34, 395, DateTimeKind.Unspecified).AddTicks(4406), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 23, 5, 34, 395, DateTimeKind.Unspecified).AddTicks(4411), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.InsertData(
                schema: "17114131",
                table: "PointsOfInterest",
                columns: new[] { "Id", "CityId", "Description", "Name" },
                values: new object[] { 1, 1, "That big park", "Central Park" });

            migrationBuilder.InsertData(
                schema: "17114131",
                table: "PointsOfInterest",
                columns: new[] { "Id", "CityId", "Description", "Name" },
                values: new object[] { 2, 1, "The one in which the emperor lives", "Empire State Building" });

            migrationBuilder.InsertData(
                schema: "17114131",
                table: "PointsOfInterest",
                columns: new[] { "Id", "CityId", "Description", "Name" },
                values: new object[] { 3, 2, "A splashy beauty", "The waterfall" });

            migrationBuilder.CreateIndex(
                name: "IX_PointsOfInterest_CityId",
                schema: "17114131",
                table: "PointsOfInterest",
                column: "CityId");
        }
    }
}
