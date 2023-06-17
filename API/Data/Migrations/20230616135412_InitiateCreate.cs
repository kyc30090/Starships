using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitiateCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Starships",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Model = table.Column<string>(type: "TEXT", nullable: false),
                    Manufacturer = table.Column<string>(type: "TEXT", nullable: true),
                    CostInCredits = table.Column<string>(type: "TEXT", nullable: true),
                    Length = table.Column<string>(type: "TEXT", nullable: true),
                    MaxAtmospheringSpeed = table.Column<string>(type: "TEXT", nullable: true),
                    Crew = table.Column<string>(type: "TEXT", nullable: true),
                    Passengers = table.Column<string>(type: "TEXT", nullable: true),
                    CargoCapacity = table.Column<string>(type: "TEXT", nullable: true),
                    Consumables = table.Column<string>(type: "TEXT", nullable: true),
                    HyperdriveRating = table.Column<string>(type: "TEXT", nullable: true),
                    MGLT = table.Column<string>(type: "TEXT", nullable: true),
                    StarshipClass = table.Column<string>(type: "TEXT", nullable: true),
                    Pilots = table.Column<string>(type: "TEXT", nullable: true),
                    Films = table.Column<string>(type: "TEXT", nullable: true),
                    Created = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Edited = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Url = table.Column<string>(type: "TEXT", nullable: true),
                    Image = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Starships", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Starships");
        }
    }
}
