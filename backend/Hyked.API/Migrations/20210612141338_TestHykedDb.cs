using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hyked.API.Migrations
{
    public partial class TestHykedDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                schema: "17114131",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                schema: "17114131",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Manufacturer = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Model = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PassengerSeats = table.Column<int>(type: "int", nullable: false),
                    LastModifiedUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cars_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "17114131",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Trips",
                schema: "17114131",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    FromLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ToLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    DepartureTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    AvailableSeats = table.Column<int>(type: "int", nullable: false),
                    TakenSeats = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    LastModifiedUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trips", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trips_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "17114131",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "17114131",
                table: "Users",
                columns: new[] { "Id", "LastModifiedUtc", "Password", "PhoneNumber", "Username" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2021, 6, 12, 14, 13, 37, 531, DateTimeKind.Unspecified).AddTicks(6878), new TimeSpan(0, 0, 0, 0, 0)), "password", "0878501743", "lordviet" });

            migrationBuilder.InsertData(
                schema: "17114131",
                table: "Users",
                columns: new[] { "Id", "LastModifiedUtc", "Password", "PhoneNumber", "Username" },
                values: new object[] { 2, new DateTimeOffset(new DateTime(2021, 6, 12, 14, 13, 37, 531, DateTimeKind.Unspecified).AddTicks(8017), new TimeSpan(0, 0, 0, 0, 0)), "password", "0878503131", "nix" });

            migrationBuilder.InsertData(
                schema: "17114131",
                table: "Users",
                columns: new[] { "Id", "LastModifiedUtc", "Password", "PhoneNumber", "Username" },
                values: new object[] { 3, new DateTimeOffset(new DateTime(2021, 6, 12, 14, 13, 37, 531, DateTimeKind.Unspecified).AddTicks(8028), new TimeSpan(0, 0, 0, 0, 0)), "password", "0878504141", "virgo" });

            migrationBuilder.InsertData(
                schema: "17114131",
                table: "Cars",
                columns: new[] { "Id", "Color", "LastModifiedUtc", "Manufacturer", "Model", "PassengerSeats", "UserId", "Year" },
                values: new object[,]
                {
                    { 1, "Space gray", new DateTimeOffset(new DateTime(2021, 6, 12, 14, 13, 37, 532, DateTimeKind.Unspecified).AddTicks(5506), new TimeSpan(0, 0, 0, 0, 0)), "Benz", "XLS", 4, 1, 2020 },
                    { 2, "Panda", new DateTimeOffset(new DateTime(2021, 6, 12, 14, 13, 37, 532, DateTimeKind.Unspecified).AddTicks(6415), new TimeSpan(0, 0, 0, 0, 0)), "BMW", "X6", 3, 2, 2018 },
                    { 3, "Blue", new DateTimeOffset(new DateTime(2021, 6, 12, 14, 13, 37, 532, DateTimeKind.Unspecified).AddTicks(6426), new TimeSpan(0, 0, 0, 0, 0)), "Audi", "A3", 4, 3, 2013 }
                });

            migrationBuilder.InsertData(
                schema: "17114131",
                table: "Trips",
                columns: new[] { "Id", "AvailableSeats", "DepartureTimeUtc", "FromLocation", "IsActive", "LastModifiedUtc", "Price", "TakenSeats", "ToLocation", "UserId" },
                values: new object[,]
                {
                    { 1, 3, new DateTimeOffset(new DateTime(2021, 6, 12, 14, 13, 37, 533, DateTimeKind.Unspecified).AddTicks(1857), new TimeSpan(0, 0, 0, 0, 0)), "Sofia", true, new DateTimeOffset(new DateTime(2021, 6, 12, 14, 13, 37, 533, DateTimeKind.Unspecified).AddTicks(5130), new TimeSpan(0, 0, 0, 0, 0)), 8.0, 0, "Karlovo", 1 },
                    { 2, 3, new DateTimeOffset(new DateTime(2021, 6, 12, 14, 13, 37, 533, DateTimeKind.Unspecified).AddTicks(6013), new TimeSpan(0, 0, 0, 0, 0)), "Karlovo", false, new DateTimeOffset(new DateTime(2021, 6, 12, 14, 13, 37, 533, DateTimeKind.Unspecified).AddTicks(6023), new TimeSpan(0, 0, 0, 0, 0)), 8.0, 0, "Sofia", 1 },
                    { 3, 2, new DateTimeOffset(new DateTime(2021, 6, 12, 14, 13, 37, 533, DateTimeKind.Unspecified).AddTicks(6027), new TimeSpan(0, 0, 0, 0, 0)), "Haskovo", false, new DateTimeOffset(new DateTime(2021, 6, 12, 14, 13, 37, 533, DateTimeKind.Unspecified).AddTicks(6030), new TimeSpan(0, 0, 0, 0, 0)), 10.5, 2, "Plovdiv", 2 },
                    { 4, 4, new DateTimeOffset(new DateTime(2021, 6, 12, 14, 13, 37, 533, DateTimeKind.Unspecified).AddTicks(6033), new TimeSpan(0, 0, 0, 0, 0)), "Sofia", true, new DateTimeOffset(new DateTime(2021, 6, 12, 14, 13, 37, 533, DateTimeKind.Unspecified).AddTicks(6036), new TimeSpan(0, 0, 0, 0, 0)), 20.0, 2, "Varna", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_UserId",
                schema: "17114131",
                table: "Cars",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Trips_UserId",
                schema: "17114131",
                table: "Trips",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars",
                schema: "17114131");

            migrationBuilder.DropTable(
                name: "Trips",
                schema: "17114131");

            migrationBuilder.DropTable(
                name: "Users",
                schema: "17114131");
        }
    }
}
