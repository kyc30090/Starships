using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class Pilots : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonStarship",
                columns: table => new
                {
                    PilotsId = table.Column<int>(type: "INTEGER", nullable: false),
                    StarshipsId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonStarship", x => new { x.PilotsId, x.StarshipsId });
                    table.ForeignKey(
                        name: "FK_PersonStarship_People_PilotsId",
                        column: x => x.PilotsId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonStarship_Starships_StarshipsId",
                        column: x => x.StarshipsId,
                        principalTable: "Starships",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Luke Skywalker" },
                    { 2, "C-3PO" },
                    { 3, "R2-D2" },
                    { 4, "Darth Vader" },
                    { 5, "Leia Organa" },
                    { 6, "Owen Lars" },
                    { 7, "Beru Whitesun lars" },
                    { 8, "R5-D4" },
                    { 9, "Biggs Darklighter" },
                    { 10, "Obi-Wan Kenobi" },
                    { 11, "Anakin Skywalker" },
                    { 12, "Wilhuff Tarkin" },
                    { 13, "Chewbacca" },
                    { 14, "Han Solo" },
                    { 15, "Greedo" },
                    { 16, "Jabba Desilijic Tiure" },
                    { 18, "Wedge Antilles" },
                    { 19, "Jek Tono Porkins" },
                    { 20, "Yoda" },
                    { 21, "Palpatine" },
                    { 22, "Boba Fett" },
                    { 23, "IG-88" },
                    { 24, "Bossk" },
                    { 25, "Lando Calrissian" },
                    { 26, "Lobot" },
                    { 27, "Ackbar" },
                    { 28, "Mon Mothma" },
                    { 29, "Arvel Crynyd" },
                    { 30, "Wicket Systri Warrick" },
                    { 31, "Nien Nunb" },
                    { 32, "Qui-Gon Jinn" },
                    { 33, "Nute Gunray" },
                    { 34, "Finis Valorum" },
                    { 35, "Padmé Amidala" },
                    { 36, "Jar Jar Binks" },
                    { 37, "Roos Tarpals" },
                    { 38, "Rugor Nass" },
                    { 39, "Ric Olié" },
                    { 40, "Watto" },
                    { 41, "Sebulba" },
                    { 42, "Quarsh Panaka" },
                    { 43, "Shmi Skywalker" },
                    { 44, "Darth Maul" },
                    { 45, "Bib Fortuna" },
                    { 46, "Ayla Secura" },
                    { 47, "Ratts Tyerel" },
                    { 48, "Dud Bolt" },
                    { 49, "Gasgano" },
                    { 50, "Ben Quadinaros" },
                    { 51, "Mace Windu" },
                    { 52, "Ki-Adi-Mundi" },
                    { 53, "Kit Fisto" },
                    { 54, "Eeth Koth" },
                    { 55, "Adi Gallia" },
                    { 56, "Saesee Tiin" },
                    { 57, "Yarael Poof" },
                    { 58, "Plo Koon" },
                    { 59, "Mas Amedda" },
                    { 60, "Gregar Typho" },
                    { 61, "Cordé" },
                    { 62, "Cliegg Lars" },
                    { 63, "Poggle the Lesser" },
                    { 64, "Luminara Unduli" },
                    { 65, "Barriss Offee" },
                    { 66, "Dormé" },
                    { 67, "Dooku" },
                    { 68, "Bail Prestor Organa" },
                    { 69, "Jango Fett" },
                    { 70, "Zam Wesell" },
                    { 71, "Dexter Jettster" },
                    { 72, "Lama Su" },
                    { 73, "Taun We" },
                    { 74, "Jocasta Nu" },
                    { 75, "LR4-P17" },
                    { 76, "Wat Tambor" },
                    { 77, "San Hill" },
                    { 78, "Shaak Ti" },
                    { 79, "Grievous" },
                    { 80, "Tarfful" },
                    { 81, "Raymus Antilles" },
                    { 82, "Sly Moore" },
                    { 83, "Tion Medon" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonStarship_StarshipsId",
                table: "PersonStarship",
                column: "StarshipsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonStarship");

            migrationBuilder.DropTable(
                name: "People");
        }
    }
}
