using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hyked.API.Migrations
{
    public partial class TripPassenger : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TakenSeats",
                schema: "17114131",
                table: "Trips");

            migrationBuilder.CreateTable(
                name: "TripPassengers",
                schema: "17114131",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TripId = table.Column<int>(type: "int", nullable: false),
                    PassengerUsername = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TripPassengers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TripPassengers_Trips_TripId",
                        column: x => x.TripId,
                        principalSchema: "17114131",
                        principalTable: "Trips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_TripPassengers_TripId",
                schema: "17114131",
                table: "TripPassengers",
                column: "TripId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TripPassengers",
                schema: "17114131");

            migrationBuilder.AddColumn<int>(
                name: "TakenSeats",
                schema: "17114131",
                table: "Trips",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                columns: new[] { "DepartureTimeUtc", "LastModifiedUtc", "TakenSeats" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 13, 1, 25, 10, 355, DateTimeKind.Unspecified).AddTicks(5610), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 6, 13, 1, 25, 10, 355, DateTimeKind.Unspecified).AddTicks(5612), new TimeSpan(0, 0, 0, 0, 0)), 2 });

            migrationBuilder.UpdateData(
                schema: "17114131",
                table: "Trips",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DepartureTimeUtc", "LastModifiedUtc", "TakenSeats" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 13, 1, 25, 10, 355, DateTimeKind.Unspecified).AddTicks(5615), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 6, 13, 1, 25, 10, 355, DateTimeKind.Unspecified).AddTicks(5616), new TimeSpan(0, 0, 0, 0, 0)), 2 });

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
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2021, 6, 13, 1, 25, 10, 352, DateTimeKind.Unspecified).AddTicks(5181), new TimeSpan(0, 0, 0, 0, 0)));
        }
    }
}
