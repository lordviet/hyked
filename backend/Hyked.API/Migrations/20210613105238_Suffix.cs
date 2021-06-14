using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hyked.API.Migrations
{
    public partial class Suffix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastModifiedUtc",
                schema: "17114131",
                table: "Users",
                newName: "LastModifiedUtc17114131");

            migrationBuilder.RenameColumn(
                name: "LastModifiedUtc",
                schema: "17114131",
                table: "Trips",
                newName: "LastModifiedUtc17114131");

            migrationBuilder.RenameColumn(
                name: "LastModifiedUtc",
                schema: "17114131",
                table: "TripPassengers",
                newName: "LastModifiedUtc17114131");

            migrationBuilder.RenameColumn(
                name: "TimeOfOperationUtc",
                schema: "17114131",
                table: "log_17114131",
                newName: "TimeOfOperationUtc17114131");

            migrationBuilder.RenameColumn(
                name: "LastModifiedUtc",
                schema: "17114131",
                table: "Cars",
                newName: "LastModifiedUtc17114131");

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
                columns: new[] { "DepartureTimeUtc", "LastModifiedUtc17114131" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 13, 10, 52, 37, 669, DateTimeKind.Unspecified).AddTicks(1162), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 6, 13, 10, 52, 37, 669, DateTimeKind.Unspecified).AddTicks(1168), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Trips",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DepartureTimeUtc", "LastModifiedUtc17114131" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 13, 10, 52, 37, 669, DateTimeKind.Unspecified).AddTicks(1175), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 6, 13, 10, 52, 37, 669, DateTimeKind.Unspecified).AddTicks(1178), new TimeSpan(0, 0, 0, 0, 0)) });

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
                column: "LastModifiedUtc17114131",
                value: new DateTimeOffset(new DateTime(2021, 6, 13, 10, 52, 37, 663, DateTimeKind.Unspecified).AddTicks(3717), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedUtc17114131",
                value: new DateTimeOffset(new DateTime(2021, 6, 13, 10, 52, 37, 663, DateTimeKind.Unspecified).AddTicks(3725), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedUtc17114131",
                value: new DateTimeOffset(new DateTime(2021, 6, 13, 10, 52, 37, 663, DateTimeKind.Unspecified).AddTicks(3731), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedUtc17114131",
                value: new DateTimeOffset(new DateTime(2021, 6, 13, 10, 52, 37, 663, DateTimeKind.Unspecified).AddTicks(3737), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedUtc17114131",
                value: new DateTimeOffset(new DateTime(2021, 6, 13, 10, 52, 37, 663, DateTimeKind.Unspecified).AddTicks(3743), new TimeSpan(0, 0, 0, 0, 0)));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastModifiedUtc17114131",
                schema: "17114131",
                table: "Users",
                newName: "LastModifiedUtc");

            migrationBuilder.RenameColumn(
                name: "LastModifiedUtc17114131",
                schema: "17114131",
                table: "Trips",
                newName: "LastModifiedUtc");

            migrationBuilder.RenameColumn(
                name: "LastModifiedUtc17114131",
                schema: "17114131",
                table: "TripPassengers",
                newName: "LastModifiedUtc");

            migrationBuilder.RenameColumn(
                name: "TimeOfOperationUtc17114131",
                schema: "17114131",
                table: "log_17114131",
                newName: "TimeOfOperationUtc");

            migrationBuilder.RenameColumn(
                name: "LastModifiedUtc17114131",
                schema: "17114131",
                table: "Cars",
                newName: "LastModifiedUtc");

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2021, 6, 13, 1, 55, 43, 168, DateTimeKind.Unspecified).AddTicks(6620), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2021, 6, 13, 1, 55, 43, 168, DateTimeKind.Unspecified).AddTicks(7397), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2021, 6, 13, 1, 55, 43, 168, DateTimeKind.Unspecified).AddTicks(7406), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Trips",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DepartureTimeUtc", "LastModifiedUtc" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 13, 1, 55, 43, 169, DateTimeKind.Unspecified).AddTicks(2648), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 6, 13, 1, 55, 43, 169, DateTimeKind.Unspecified).AddTicks(5175), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Trips",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DepartureTimeUtc", "LastModifiedUtc" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 13, 1, 55, 43, 169, DateTimeKind.Unspecified).AddTicks(5869), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 6, 13, 1, 55, 43, 169, DateTimeKind.Unspecified).AddTicks(5873), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Trips",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DepartureTimeUtc", "LastModifiedUtc" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 13, 1, 55, 43, 169, DateTimeKind.Unspecified).AddTicks(5878), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 6, 13, 1, 55, 43, 169, DateTimeKind.Unspecified).AddTicks(5879), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Trips",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DepartureTimeUtc", "LastModifiedUtc" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 13, 1, 55, 43, 169, DateTimeKind.Unspecified).AddTicks(5883), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 6, 13, 1, 55, 43, 169, DateTimeKind.Unspecified).AddTicks(5885), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2021, 6, 13, 1, 55, 43, 166, DateTimeKind.Unspecified).AddTicks(2622), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2021, 6, 13, 1, 55, 43, 166, DateTimeKind.Unspecified).AddTicks(3451), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2021, 6, 13, 1, 55, 43, 166, DateTimeKind.Unspecified).AddTicks(3461), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2021, 6, 13, 1, 55, 43, 166, DateTimeKind.Unspecified).AddTicks(3464), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2021, 6, 13, 1, 55, 43, 166, DateTimeKind.Unspecified).AddTicks(3467), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2021, 6, 13, 1, 55, 43, 166, DateTimeKind.Unspecified).AddTicks(3469), new TimeSpan(0, 0, 0, 0, 0)));
        }
    }
}
