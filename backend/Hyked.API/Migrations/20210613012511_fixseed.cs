using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hyked.API.Migrations
{
    public partial class fixseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2021, 6, 13, 1, 25, 10, 354, DateTimeKind.Unspecified).AddTicks(7060), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2021, 6, 13, 1, 25, 10, 354, DateTimeKind.Unspecified).AddTicks(7771), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2021, 6, 13, 1, 25, 10, 354, DateTimeKind.Unspecified).AddTicks(7780), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Trips",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DepartureTimeUtc", "LastModifiedUtc" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 13, 1, 25, 10, 355, DateTimeKind.Unspecified).AddTicks(2311), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 6, 13, 1, 25, 10, 355, DateTimeKind.Unspecified).AddTicks(4863), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Trips",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DepartureTimeUtc", "LastModifiedUtc" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 13, 1, 25, 10, 355, DateTimeKind.Unspecified).AddTicks(5604), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 6, 13, 1, 25, 10, 355, DateTimeKind.Unspecified).AddTicks(5606), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Trips",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DepartureTimeUtc", "LastModifiedUtc" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 13, 1, 25, 10, 355, DateTimeKind.Unspecified).AddTicks(5610), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 6, 13, 1, 25, 10, 355, DateTimeKind.Unspecified).AddTicks(5612), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Trips",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DepartureTimeUtc", "LastModifiedUtc" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 13, 1, 25, 10, 355, DateTimeKind.Unspecified).AddTicks(5615), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 6, 13, 1, 25, 10, 355, DateTimeKind.Unspecified).AddTicks(5616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2021, 6, 13, 1, 25, 10, 352, DateTimeKind.Unspecified).AddTicks(4365), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2021, 6, 13, 1, 25, 10, 352, DateTimeKind.Unspecified).AddTicks(5165), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2021, 6, 13, 1, 25, 10, 352, DateTimeKind.Unspecified).AddTicks(5174), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2021, 6, 13, 1, 25, 10, 352, DateTimeKind.Unspecified).AddTicks(5177), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2021, 6, 13, 1, 25, 10, 352, DateTimeKind.Unspecified).AddTicks(5179), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "LastModifiedUtc", "Username" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 13, 1, 25, 10, 352, DateTimeKind.Unspecified).AddTicks(5181), new TimeSpan(0, 0, 0, 0, 0)), "Boro The 2nd" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2021, 6, 13, 1, 9, 48, 28, DateTimeKind.Unspecified).AddTicks(1240), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2021, 6, 13, 1, 9, 48, 28, DateTimeKind.Unspecified).AddTicks(1911), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2021, 6, 13, 1, 9, 48, 28, DateTimeKind.Unspecified).AddTicks(1920), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Trips",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DepartureTimeUtc", "LastModifiedUtc" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 13, 1, 9, 48, 28, DateTimeKind.Unspecified).AddTicks(6125), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 6, 13, 1, 9, 48, 28, DateTimeKind.Unspecified).AddTicks(8617), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Trips",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DepartureTimeUtc", "LastModifiedUtc" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 13, 1, 9, 48, 28, DateTimeKind.Unspecified).AddTicks(9316), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 6, 13, 1, 9, 48, 28, DateTimeKind.Unspecified).AddTicks(9319), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Trips",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DepartureTimeUtc", "LastModifiedUtc" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 13, 1, 9, 48, 28, DateTimeKind.Unspecified).AddTicks(9322), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 6, 13, 1, 9, 48, 28, DateTimeKind.Unspecified).AddTicks(9323), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Trips",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DepartureTimeUtc", "LastModifiedUtc" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 13, 1, 9, 48, 28, DateTimeKind.Unspecified).AddTicks(9326), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 6, 13, 1, 9, 48, 28, DateTimeKind.Unspecified).AddTicks(9328), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2021, 6, 13, 1, 9, 48, 25, DateTimeKind.Unspecified).AddTicks(9700), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2021, 6, 13, 1, 9, 48, 26, DateTimeKind.Unspecified).AddTicks(452), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2021, 6, 13, 1, 9, 48, 26, DateTimeKind.Unspecified).AddTicks(461), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2021, 6, 13, 1, 9, 48, 26, DateTimeKind.Unspecified).AddTicks(463), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2021, 6, 13, 1, 9, 48, 26, DateTimeKind.Unspecified).AddTicks(466), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "LastModifiedUtc", "Username" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 13, 1, 9, 48, 26, DateTimeKind.Unspecified).AddTicks(468), new TimeSpan(0, 0, 0, 0, 0)), "Boro The 1st" });
        }
    }
}
