using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hyked.API.Migrations
{
    public partial class FinalSample : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "17114131",
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

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
                column: "LastModifiedUtc17114131",
                value: new DateTimeOffset(new DateTime(2021, 6, 14, 2, 55, 47, 318, DateTimeKind.Unspecified).AddTicks(4034), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedUtc17114131",
                value: new DateTimeOffset(new DateTime(2021, 6, 14, 2, 55, 47, 318, DateTimeKind.Unspecified).AddTicks(4985), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedUtc17114131",
                value: new DateTimeOffset(new DateTime(2021, 6, 14, 2, 55, 47, 318, DateTimeKind.Unspecified).AddTicks(4995), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Trips",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DepartureTimeUtc", "LastModifiedUtc17114131" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 14, 2, 55, 47, 319, DateTimeKind.Unspecified).AddTicks(1313), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 6, 14, 2, 55, 47, 319, DateTimeKind.Unspecified).AddTicks(4163), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Trips",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DepartureTimeUtc", "IsActive", "LastModifiedUtc17114131" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 14, 2, 55, 47, 319, DateTimeKind.Unspecified).AddTicks(4876), new TimeSpan(0, 0, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2021, 6, 14, 2, 55, 47, 319, DateTimeKind.Unspecified).AddTicks(4879), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Trips",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DepartureTimeUtc", "IsActive", "LastModifiedUtc17114131" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 14, 2, 55, 47, 319, DateTimeKind.Unspecified).AddTicks(4885), new TimeSpan(0, 0, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2021, 6, 14, 2, 55, 47, 319, DateTimeKind.Unspecified).AddTicks(4888), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Trips",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DepartureTimeUtc", "LastModifiedUtc17114131" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 14, 2, 55, 47, 319, DateTimeKind.Unspecified).AddTicks(4893), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 6, 14, 2, 55, 47, 319, DateTimeKind.Unspecified).AddTicks(4896), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedUtc17114131",
                value: new DateTimeOffset(new DateTime(2021, 6, 14, 2, 55, 47, 314, DateTimeKind.Unspecified).AddTicks(9811), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "LastModifiedUtc17114131", "Username" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 14, 2, 55, 47, 315, DateTimeKind.Unspecified).AddTicks(1122), new TimeSpan(0, 0, 0, 0, 0)), "Hawkins" });

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "LastModifiedUtc17114131", "Username" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 14, 2, 55, 47, 315, DateTimeKind.Unspecified).AddTicks(1133), new TimeSpan(0, 0, 0, 0, 0)), "Steve" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedUtc17114131",
                value: new DateTimeOffset(new DateTime(2021, 6, 13, 10, 52, 37, 666, DateTimeKind.Unspecified).AddTicks(6345), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedUtc17114131",
                value: new DateTimeOffset(new DateTime(2021, 6, 13, 10, 52, 37, 666, DateTimeKind.Unspecified).AddTicks(7335), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedUtc17114131",
                value: new DateTimeOffset(new DateTime(2021, 6, 13, 10, 52, 37, 666, DateTimeKind.Unspecified).AddTicks(7341), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Trips",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DepartureTimeUtc", "LastModifiedUtc17114131" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 13, 10, 52, 37, 667, DateTimeKind.Unspecified).AddTicks(6431), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 6, 13, 10, 52, 37, 669, DateTimeKind.Unspecified).AddTicks(38), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Trips",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DepartureTimeUtc", "IsActive", "LastModifiedUtc17114131" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 13, 10, 52, 37, 669, DateTimeKind.Unspecified).AddTicks(1162), new TimeSpan(0, 0, 0, 0, 0)), false, new DateTimeOffset(new DateTime(2021, 6, 13, 10, 52, 37, 669, DateTimeKind.Unspecified).AddTicks(1168), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Trips",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DepartureTimeUtc", "IsActive", "LastModifiedUtc17114131" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 13, 10, 52, 37, 669, DateTimeKind.Unspecified).AddTicks(1175), new TimeSpan(0, 0, 0, 0, 0)), false, new DateTimeOffset(new DateTime(2021, 6, 13, 10, 52, 37, 669, DateTimeKind.Unspecified).AddTicks(1178), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Trips",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DepartureTimeUtc", "LastModifiedUtc17114131" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 13, 10, 52, 37, 669, DateTimeKind.Unspecified).AddTicks(1186), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 6, 13, 10, 52, 37, 669, DateTimeKind.Unspecified).AddTicks(1188), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedUtc17114131",
                value: new DateTimeOffset(new DateTime(2021, 6, 13, 10, 52, 37, 663, DateTimeKind.Unspecified).AddTicks(2635), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "LastModifiedUtc17114131", "Username" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 13, 10, 52, 37, 663, DateTimeKind.Unspecified).AddTicks(3717), new TimeSpan(0, 0, 0, 0, 0)), "nix" });

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "LastModifiedUtc17114131", "Username" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 13, 10, 52, 37, 663, DateTimeKind.Unspecified).AddTicks(3725), new TimeSpan(0, 0, 0, 0, 0)), "virgo" });

            migrationBuilder.InsertData(
                schema: "17114131",
                table: "Users",
                columns: new[] { "Id", "LastModifiedUtc17114131", "Password", "PhoneNumber", "Username" },
                values: new object[,]
                {
                    { 4, new DateTimeOffset(new DateTime(2021, 6, 13, 10, 52, 37, 663, DateTimeKind.Unspecified).AddTicks(3731), new TimeSpan(0, 0, 0, 0, 0)), "password", "0878504141", "Baby papa" },
                    { 5, new DateTimeOffset(new DateTime(2021, 6, 13, 10, 52, 37, 663, DateTimeKind.Unspecified).AddTicks(3737), new TimeSpan(0, 0, 0, 0, 0)), "password", "0873152341", "Boro The 1st" },
                    { 6, new DateTimeOffset(new DateTime(2021, 6, 13, 10, 52, 37, 663, DateTimeKind.Unspecified).AddTicks(3743), new TimeSpan(0, 0, 0, 0, 0)), "password", "0873152341", "Boro The 2nd" }
                });
        }
    }
}
