using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hyked.API.Migrations
{
    public partial class TestLatestValue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "LastModifiedUtc", "Username" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 13, 1, 9, 48, 26, DateTimeKind.Unspecified).AddTicks(463), new TimeSpan(0, 0, 0, 0, 0)), "Baby papa" });

            migrationBuilder.InsertData(
                schema: "17114131",
                table: "Users",
                columns: new[] { "Id", "LastModifiedUtc", "Password", "PhoneNumber", "Username" },
                values: new object[,]
                {
                    { 5, new DateTimeOffset(new DateTime(2021, 6, 13, 1, 9, 48, 26, DateTimeKind.Unspecified).AddTicks(466), new TimeSpan(0, 0, 0, 0, 0)), "password", "0873152341", "Boro The 1st" },
                    { 6, new DateTimeOffset(new DateTime(2021, 6, 13, 1, 9, 48, 26, DateTimeKind.Unspecified).AddTicks(468), new TimeSpan(0, 0, 0, 0, 0)), "password", "0873152341", "Boro The 1st" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "17114131",
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "17114131",
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

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
                columns: new[] { "LastModifiedUtc", "Username" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 12, 23, 44, 59, 437, DateTimeKind.Unspecified).AddTicks(7032), new TimeSpan(0, 0, 0, 0, 0)), "Baby mama" });
        }
    }
}
