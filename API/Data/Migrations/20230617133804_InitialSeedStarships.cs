using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialSeedStarships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Films",
                table: "Starships");

            migrationBuilder.DropColumn(
                name: "Pilots",
                table: "Starships");

            migrationBuilder.DropColumn(
                name: "Url",
                table: "Starships");

            migrationBuilder.InsertData(
                table: "Starships",
                columns: new[] { "Id", "CargoCapacity", "Consumables", "CostInCredits", "Created", "Crew", "Edited", "HyperdriveRating", "Image", "Length", "MGLT", "Manufacturer", "MaxAtmospheringSpeed", "Model", "Name", "Passengers", "StarshipClass" },
                values: new object[,]
                {
                    { 2, "3000000", "1 year", "3500000", new DateTime(2014, 12, 10, 14, 20, 33, 369, DateTimeKind.Unspecified), "30-165", new DateTime(2014, 12, 20, 21, 23, 49, 867, DateTimeKind.Unspecified), "2.0", null, "150", "60", "Corellian Engineering Corporation", "950", "CR90 corvette", "CR90 corvette", "600", "corvette" },
                    { 3, "36000000", "2 years", "150000000", new DateTime(2014, 12, 10, 15, 8, 19, 848, DateTimeKind.Unspecified), "47,060", new DateTime(2014, 12, 20, 21, 23, 49, 870, DateTimeKind.Unspecified), "2.0", null, "1,600", "60", "Kuat Drive Yards", "975", "Imperial I-class Star Destroyer", "Star Destroyer", "n/a", "Star Destroyer" },
                    { 5, "180000", "1 month", "240000", new DateTime(2014, 12, 10, 15, 48, 0, 586, DateTimeKind.Unspecified), "5", new DateTime(2014, 12, 20, 21, 23, 49, 873, DateTimeKind.Unspecified), "1.0", null, "38", "70", "Sienar Fleet Systems, Cyngus Spaceworks", "1000", "Sentinel-class landing craft", "Sentinel-class landing craft", "75", "landing craft" },
                    { 9, "1000000000000", "3 years", "1000000000000", new DateTime(2014, 12, 10, 16, 36, 50, 509, DateTimeKind.Unspecified), "342,953", new DateTime(2014, 12, 20, 21, 26, 24, 783, DateTimeKind.Unspecified), "4.0", null, "120000", "10", "Imperial Department of Military Research, Sienar Fleet Systems", "n/a", "DS-1 Orbital Battle Station", "Death Star", "843,342", "Deep Space Mobile Battlestation" },
                    { 10, "100000", "2 months", "100000", new DateTime(2014, 12, 10, 16, 59, 45, 94, DateTimeKind.Unspecified), "4", new DateTime(2014, 12, 20, 21, 23, 49, 880, DateTimeKind.Unspecified), "0.5", null, "34.37", "75", "Corellian Engineering Corporation", "1050", "YT-1300 light freighter", "Millennium Falcon", "6", "Light freighter" },
                    { 11, "110", "1 week", "134999", new DateTime(2014, 12, 12, 11, 0, 39, 817, DateTimeKind.Unspecified), "2", new DateTime(2014, 12, 20, 21, 23, 49, 883, DateTimeKind.Unspecified), "1.0", null, "14", "80", "Koensayr Manufacturing", "1000km", "BTL Y-wing", "Y-wing", "0", "assault starfighter" },
                    { 12, "110", "1 week", "149999", new DateTime(2014, 12, 12, 11, 19, 5, 340, DateTimeKind.Unspecified), "1", new DateTime(2014, 12, 20, 21, 23, 49, 886, DateTimeKind.Unspecified), "1.0", null, "12.5", "100", "Incom Corporation", "1050", "T-65 X-wing", "X-wing", "0", "Starfighter" },
                    { 13, "150", "5 days", "unknown", new DateTime(2014, 12, 12, 11, 21, 32, 991, DateTimeKind.Unspecified), "1", new DateTime(2014, 12, 20, 21, 23, 49, 889, DateTimeKind.Unspecified), "1.0", null, "9.2", "105", "Sienar Fleet Systems", "1200", "Twin Ion Engine Advanced x1", "TIE Advanced x1", "0", "Starfighter" },
                    { 15, "250000000", "6 years", "1143350000", new DateTime(2014, 12, 15, 12, 31, 42, 547, DateTimeKind.Unspecified), "279,144", new DateTime(2014, 12, 20, 21, 23, 49, 893, DateTimeKind.Unspecified), "2.0", null, "19000", "40", "Kuat Drive Yards, Fondor Shipyards", "n/a", "Executor-class star dreadnought", "Executor", "38000", "Star dreadnought" },
                    { 17, "19000000", "6 months", "unknown", new DateTime(2014, 12, 15, 12, 34, 52, 264, DateTimeKind.Utc), "6", new DateTime(2014, 12, 20, 21, 23, 49, 895, DateTimeKind.Utc), "4.0", null, "90", "20", "Gallofree Yards, Inc.", "650", "GR-75 medium transport", "Rebel transport", "90", "Medium transport" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Starships",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Starships",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Starships",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Starships",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Starships",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Starships",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Starships",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Starships",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Starships",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Starships",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.AddColumn<string>(
                name: "Films",
                table: "Starships",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Pilots",
                table: "Starships",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Starships",
                type: "TEXT",
                nullable: true);
        }
    }
}
