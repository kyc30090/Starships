using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class SqlServerInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EpisodeId = table.Column<int>(type: "int", nullable: false),
                    OpeningCrawl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Starships",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CostInCredits = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Length = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaxAtmospheringSpeed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Crew = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Passengers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CargoCapacity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Consumables = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HyperdriveRating = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MGLT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StarshipClass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Edited = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Starships", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FilmStarship",
                columns: table => new
                {
                    FilmsId = table.Column<int>(type: "int", nullable: false),
                    StarshipsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmStarship", x => new { x.FilmsId, x.StarshipsId });
                    table.ForeignKey(
                        name: "FK_FilmStarship_Films_FilmsId",
                        column: x => x.FilmsId,
                        principalTable: "Films",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FilmStarship_Starships_StarshipsId",
                        column: x => x.StarshipsId,
                        principalTable: "Starships",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonStarship",
                columns: table => new
                {
                    PilotsId = table.Column<int>(type: "int", nullable: false),
                    StarshipsId = table.Column<int>(type: "int", nullable: false)
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
                table: "Films",
                columns: new[] { "Id", "EpisodeId", "OpeningCrawl", "Title" },
                values: new object[,]
                {
                    { 1, 4, "It is a period of civil war.\r\nRebel spaceships, striking\r\nfrom a hidden base, have won\r\ntheir first victory against\r\nthe evil Galactic Empire.\r\n\r\nDuring the battle, Rebel\r\nspies managed to steal secret\r\nplans to the Empire's\r\nultimate weapon, the DEATH\r\nSTAR, an armored space\r\nstation with enough power\r\nto destroy an entire planet.\r\n\r\nPursued by the Empire's\r\nsinister agents, Princess\r\nLeia races home aboard her\r\nstarship, custodian of the\r\nstolen plans that can save her\r\npeople and restore\r\nfreedom to the galaxy....", "A New Hope" },
                    { 2, 5, "It is a dark time for the\r\nRebellion. Although the Death\r\nStar has been destroyed,\r\nImperial troops have driven the\r\nRebel forces from their hidden\r\nbase and pursued them across\r\nthe galaxy.\r\n\r\nEvading the dreaded Imperial\r\nStarfleet, a group of freedom\r\nfighters led by Luke Skywalker\r\nhas established a new secret\r\nbase on the remote ice world\r\nof Hoth.\r\n\r\nThe evil lord Darth Vader,\r\nobsessed with finding young\r\nSkywalker, has dispatched\r\nthousands of remote probes into\r\nthe far reaches of space...", "The Empire Strikes Back" },
                    { 3, 6, "Luke Skywalker has returned to\r\nhis home planet of Tatooine in\r\nan attempt to rescue his\r\nfriend Han Solo from the\r\nclutches of the vile gangster\r\nJabba the Hutt.\r\n\r\nLittle does Luke know that the\r\nGALACTIC EMPIRE has secretly\r\nbegun construction on a new\r\narmored space station even\r\nmore powerful than the first\r\ndreaded Death Star.\r\n\r\nWhen completed, this ultimate\r\nweapon will spell certain doom\r\nfor the small band of rebels\r\nstruggling to restore freedom\r\nto the galaxy...", "Return of the Jedi" },
                    { 4, 1, "Turmoil has engulfed the\r\nGalactic Republic. The taxation\r\nof trade routes to outlying star\r\nsystems is in dispute.\r\n\r\nHoping to resolve the matter\r\nwith a blockade of deadly\r\nbattleships, the greedy Trade\r\nFederation has stopped all\r\nshipping to the small planet\r\nof Naboo.\r\n\r\nWhile the Congress of the\r\nRepublic endlessly debates\r\nthis alarming chain of events,\r\nthe Supreme Chancellor has\r\nsecretly dispatched two Jedi\r\nKnights, the guardians of\r\npeace and justice in the\r\ngalaxy, to settle the conflict....", "The Phantom Menace" },
                    { 5, 2, "There is unrest in the Galactic\r\nSenate. Several thousand solar\r\nsystems have declared their\r\nintentions to leave the Republic.\r\n\r\nThis separatist movement,\r\nunder the leadership of the\r\nmysterious Count Dooku, has\r\nmade it difficult for the limited\r\nnumber of Jedi Knights to maintain \r\npeace and order in the galaxy.\r\n\r\nSenator Amidala, the former\r\nQueen of Naboo, is returning\r\nto the Galactic Senate to vote\r\non the critical issue of creating\r\nan ARMY OF THE REPUBLIC\r\nto assist the overwhelmed\r\nJedi....", "Attack of the Clones" },
                    { 6, 3, "War! The Republic is crumbling\r\nunder attacks by the ruthless\r\nSith Lord, Count Dooku.\r\nThere are heroes on both sides.\r\nEvil is everywhere.\r\n\r\nIn a stunning move, the\r\nfiendish droid leader, General\r\nGrievous, has swept into the\r\nRepublic capital and kidnapped\r\nChancellor Palpatine, leader of\r\nthe Galactic Senate.\r\n\r\nAs the Separatist Droid Army\r\nattempts to flee the besieged\r\ncapital with their valuable\r\nhostage, two Jedi Knights lead a\r\ndesperate mission to rescue the\r\ncaptive Chancellor....", "Revenge of the Sith" }
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

            migrationBuilder.InsertData(
                table: "Starships",
                columns: new[] { "Id", "CargoCapacity", "Consumables", "CostInCredits", "Created", "Crew", "Edited", "HyperdriveRating", "Image", "Length", "MGLT", "Manufacturer", "MaxAtmospheringSpeed", "Model", "Name", "Passengers", "StarshipClass" },
                values: new object[,]
                {
                    { 2, "3000000", "1 year", "3500000", new DateTime(2014, 12, 10, 14, 20, 33, 369, DateTimeKind.Unspecified), "30-165", new DateTime(2014, 12, 20, 21, 23, 49, 867, DateTimeKind.Unspecified), "2.0", "https://starships.blob.core.windows.net/starship-api/2.jpeg", "150", "60", "Corellian Engineering Corporation", "950", "CR90 corvette", "CR90 corvette", "600", "corvette" },
                    { 3, "36000000", "2 years", "150000000", new DateTime(2014, 12, 10, 15, 8, 19, 848, DateTimeKind.Unspecified), "47,060", new DateTime(2014, 12, 20, 21, 23, 49, 870, DateTimeKind.Unspecified), "2.0", "https://starships.blob.core.windows.net/starship-api/3.jpeg", "1,600", "60", "Kuat Drive Yards", "975", "Imperial I-class Star Destroyer", "Star Destroyer", "n/a", "Star Destroyer" },
                    { 5, "180000", "1 month", "240000", new DateTime(2014, 12, 10, 15, 48, 0, 586, DateTimeKind.Unspecified), "5", new DateTime(2014, 12, 20, 21, 23, 49, 873, DateTimeKind.Unspecified), "1.0", "https://starships.blob.core.windows.net/starship-api/5.jpeg", "38", "70", "Sienar Fleet Systems, Cyngus Spaceworks", "1000", "Sentinel-class landing craft", "Sentinel-class landing craft", "75", "landing craft" },
                    { 9, "1000000000000", "3 years", "1000000000000", new DateTime(2014, 12, 10, 16, 36, 50, 509, DateTimeKind.Unspecified), "342,953", new DateTime(2014, 12, 20, 21, 26, 24, 783, DateTimeKind.Unspecified), "4.0", "https://starships.blob.core.windows.net/starship-api/9.jpeg", "120000", "10", "Imperial Department of Military Research, Sienar Fleet Systems", "n/a", "DS-1 Orbital Battle Station", "Death Star", "843,342", "Deep Space Mobile Battlestation" },
                    { 10, "100000", "2 months", "100000", new DateTime(2014, 12, 10, 16, 59, 45, 94, DateTimeKind.Unspecified), "4", new DateTime(2014, 12, 20, 21, 23, 49, 880, DateTimeKind.Unspecified), "0.5", "https://starships.blob.core.windows.net/starship-api/10.jpeg", "34.37", "75", "Corellian Engineering Corporation", "1050", "YT-1300 light freighter", "Millennium Falcon", "6", "Light freighter" },
                    { 11, "110", "1 week", "134999", new DateTime(2014, 12, 12, 11, 0, 39, 817, DateTimeKind.Unspecified), "2", new DateTime(2014, 12, 20, 21, 23, 49, 883, DateTimeKind.Unspecified), "1.0", "https://starships.blob.core.windows.net/starship-api/11.jpeg", "14", "80", "Koensayr Manufacturing", "1000km", "BTL Y-wing", "Y-wing", "0", "assault starfighter" },
                    { 12, "110", "1 week", "149999", new DateTime(2014, 12, 12, 11, 19, 5, 340, DateTimeKind.Unspecified), "1", new DateTime(2014, 12, 20, 21, 23, 49, 886, DateTimeKind.Unspecified), "1.0", "https://starships.blob.core.windows.net/starship-api/12.jpeg", "12.5", "100", "Incom Corporation", "1050", "T-65 X-wing", "X-wing", "0", "Starfighter" },
                    { 13, "150", "5 days", "unknown", new DateTime(2014, 12, 12, 11, 21, 32, 991, DateTimeKind.Unspecified), "1", new DateTime(2014, 12, 20, 21, 23, 49, 889, DateTimeKind.Unspecified), "1.0", "https://starships.blob.core.windows.net/starship-api/13.jpeg", "9.2", "105", "Sienar Fleet Systems", "1200", "Twin Ion Engine Advanced x1", "TIE Advanced x1", "0", "Starfighter" },
                    { 15, "250000000", "6 years", "1143350000", new DateTime(2014, 12, 15, 12, 31, 42, 547, DateTimeKind.Unspecified), "279,144", new DateTime(2014, 12, 20, 21, 23, 49, 893, DateTimeKind.Unspecified), "2.0", "https://starships.blob.core.windows.net/starship-api/15.jpeg", "19000", "40", "Kuat Drive Yards, Fondor Shipyards", "n/a", "Executor-class star dreadnought", "Executor", "38000", "Star dreadnought" },
                    { 17, "19000000", "6 months", "unknown", new DateTime(2014, 12, 15, 12, 34, 52, 264, DateTimeKind.Utc), "6", new DateTime(2014, 12, 20, 21, 23, 49, 895, DateTimeKind.Utc), "4.0", "https://starships.blob.core.windows.net/starship-api/17.jpeg", "90", "20", "Gallofree Yards, Inc.", "650", "GR-75 medium transport", "Rebel transport", "90", "Medium transport" },
                    { 21, "70000", "1 month", "unknown", new DateTime(2014, 12, 15, 13, 0, 56, 332, DateTimeKind.Utc), "1", new DateTime(2014, 12, 20, 21, 23, 49, 897, DateTimeKind.Utc), "3.0", "https://starships.blob.core.windows.net/starship-api/21.jpeg", "21.5", "70", "Kuat Systems Engineering", "1000", "Firespray-31-class patrol and attack", "Slave 1", "6", "Patrol craft" },
                    { 22, "80000", "2 months", "240000", new DateTime(2014, 12, 15, 13, 4, 47, 235, DateTimeKind.Utc), "6", new DateTime(2014, 12, 20, 21, 23, 49, 900, DateTimeKind.Utc), "1.0", "https://starships.blob.core.windows.net/starship-api/22.jpeg", "20", "50", "Sienar Fleet Systems", "850", "Lambda-class T-4a shuttle", "Imperial shuttle", "20", "Armed government transport" },
                    { 23, "6000000", "2 years", "8500000", new DateTime(2014, 12, 15, 13, 6, 30, 813, DateTimeKind.Utc), "854", new DateTime(2014, 12, 20, 21, 23, 49, 902, DateTimeKind.Utc), "2.0", "https://starships.blob.core.windows.net/starship-api/23.jpeg", "300", "40", "Kuat Drive Yards", "800", "EF76 Nebulon-B escort frigate", "EF76 Nebulon-B escort frigate", "75", "Escort ship" },
                    { 27, "unknown", "2 years", "104000000", new DateTime(2014, 12, 18, 10, 54, 57, 804, DateTimeKind.Utc), "5400", new DateTime(2014, 12, 20, 21, 23, 49, 904, DateTimeKind.Utc), "1.0", "https://starships.blob.core.windows.net/starship-api/27.jpeg", "1200", "60", "Mon Calamari shipyards", "n/a", "MC80 Liberty type Star Cruiser", "Calamari Cruiser", "1200", "Star Cruiser" },
                    { 28, "40", "1 week", "175000", new DateTime(2014, 12, 18, 11, 16, 34, 542, DateTimeKind.Utc), "1", new DateTime(2014, 12, 20, 21, 23, 49, 907, DateTimeKind.Utc), "1.0", "https://starships.blob.core.windows.net/starship-api/28.jpeg", "9.6", "120", "Alliance Underground Engineering, Incom Corporation", "1300", "RZ-1 A-wing Interceptor", "A-wing", "0", "Starfighter" },
                    { 29, "45", "1 week", "220000", new DateTime(2014, 12, 18, 11, 18, 4, 763, DateTimeKind.Utc), "1", new DateTime(2014, 12, 20, 21, 23, 49, 909, DateTimeKind.Utc), "2.0", "https://starships.blob.core.windows.net/starship-api/29.jpeg", "16.9", "91", "Slayn & Korpil", "950", "A/SF-01 B-wing starfighter", "B-wing", "0", "Assault Starfighter" },
                    { 31, "unknown", "unknown", "unknown", new DateTime(2014, 12, 19, 17, 1, 31, 488, DateTimeKind.Utc), "9", new DateTime(2014, 12, 20, 21, 23, 49, 912, DateTimeKind.Utc), "2.0", "https://starships.blob.core.windows.net/starship-api/31.jpeg", "115", "unknown", "Corellian Engineering Corporation", "900", "Consular-class cruiser", "Republic Cruiser", "16", "Space cruiser" },
                    { 32, "4000000000", "500 days", "unknown", new DateTime(2014, 12, 19, 17, 4, 6, 323, DateTimeKind.Utc), "175", new DateTime(2014, 12, 20, 21, 23, 49, 915, DateTimeKind.Utc), "2.0", "https://starships.blob.core.windows.net/starship-api/32.jpeg", "3170", "unknown", "Hoersch-Kessel Drive, Inc.", "n/a", "Lucrehulk-class Droid Control Ship", "Droid control ship", "139000", "Droid control ship" },
                    { 39, "65", "7 days", "200000", new DateTime(2014, 12, 19, 17, 39, 17, 582, DateTimeKind.Utc), "1", new DateTime(2014, 12, 20, 21, 23, 49, 917, DateTimeKind.Utc), "1.0", "https://starships.blob.core.windows.net/starship-api/39.jpeg", "11", "unknown", "Theed Palace Space Vessel Engineering Corps", "1100", "N-1 starfighter", "Naboo fighter", "0", "Starfighter" },
                    { 40, "unknown", "unknown", "unknown", new DateTime(2014, 12, 19, 17, 45, 3, 506, DateTimeKind.Utc), "8", new DateTime(2014, 12, 20, 21, 23, 49, 919, DateTimeKind.Utc), "1.8", "https://starships.blob.core.windows.net/starship-api/40.jpeg", "76", "unknown", "Theed Palace Space Vessel Engineering Corps, Nubia Star Drives", "920", "J-type 327 Nubian royal starship", "Naboo Royal Starship", "unknown", "yacht" },
                    { 41, "2500000", "30 days", "55000000", new DateTime(2014, 12, 20, 9, 39, 56, 116, DateTimeKind.Utc), "1", new DateTime(2014, 12, 20, 21, 23, 49, 922, DateTimeKind.Utc), "1.5", "https://starships.blob.core.windows.net/starship-api/41.jpeg", "26.5", "unknown", "Republic Sienar Systems", "1180", "Star Courier", "Scimitar", "6", "Space Transport" },
                    { 43, "unknown", "1 year", "2000000", new DateTime(2014, 12, 20, 11, 5, 51, 237, DateTimeKind.Utc), "5", new DateTime(2014, 12, 20, 21, 23, 49, 925, DateTimeKind.Utc), "0.7", "https://starships.blob.core.windows.net/starship-api/43.jpeg", "39", "unknown", "Theed Palace Space Vessel Engineering Corps, Nubia Star Drives", "2000", "J-type diplomatic barge", "J-type diplomatic barge", "10", "Diplomatic barge" },
                    { 47, "unknown", "unknown", "unknown", new DateTime(2014, 12, 20, 17, 24, 23, 509, DateTimeKind.Utc), "unknown", new DateTime(2014, 12, 20, 21, 23, 49, 928, DateTimeKind.Utc), "unknown", "https://starships.blob.core.windows.net/starship-api/47.jpeg", "390", "unknown", "Botajef Shipyards", "unknown", "Botajef AA-9 Freighter-Liner", "AA-9 Coruscant freighter", "30000", "freighter" },
                    { 48, "60", "7 days", "180000", new DateTime(2014, 12, 20, 17, 35, 23, 906, DateTimeKind.Utc), "1", new DateTime(2014, 12, 20, 21, 23, 49, 930, DateTimeKind.Utc), "1.0", "https://starships.blob.core.windows.net/starship-api/48.jpeg", "8", "unknown", "Kuat Systems Engineering", "1150", "Delta-7 Aethersprite-class interceptor", "Jedi starfighter", "0", "Starfighter" },
                    { 49, "unknown", "unknown", "unknown", new DateTime(2014, 12, 20, 17, 46, 46, 847, DateTimeKind.Utc), "4", new DateTime(2014, 12, 20, 21, 23, 49, 932, DateTimeKind.Utc), "0.9", "https://starships.blob.core.windows.net/starship-api/49.jpeg", "47.9", "unknown", "Theed Palace Space Vessel Engineering Corps", "8000", "H-type Nubian yacht", "H-type Nubian yacht", "unknown", "yacht" },
                    { 52, "11250000", "2 years", "unknown", new DateTime(2014, 12, 20, 18, 8, 42, 926, DateTimeKind.Utc), "700", new DateTime(2014, 12, 20, 21, 23, 49, 935, DateTimeKind.Utc), "0.6", "https://starships.blob.core.windows.net/starship-api/52.jpeg", "752", "unknown", "Rothana Heavy Engineering", "unknown", "Acclamator I-class assault ship", "Republic Assault ship", "16000", "assault ship" },
                    { 58, "240", "7 days", "35700", new DateTime(2014, 12, 20, 18, 37, 56, 969, DateTimeKind.Utc), "3", new DateTime(2014, 12, 20, 21, 23, 49, 937, DateTimeKind.Utc), "1.5", "https://starships.blob.core.windows.net/starship-api/58.jpeg", "15.2", "unknown", "Huppla Pasa Tisc Shipwrights Collective", "1600", "Punworcca 116-class interstellar sloop", "Solar Sailer", "11", "yacht" },
                    { 59, "50000000", "4 years", "125000000", new DateTime(2014, 12, 20, 19, 40, 21, 902, DateTimeKind.Utc), "600", new DateTime(2014, 12, 20, 21, 23, 49, 941, DateTimeKind.Utc), "1.5", "https://starships.blob.core.windows.net/starship-api/59.jpeg", "1088", "unknown", "Rendili StarDrive, Free Dac Volunteers Engineering corps.", "1050", "Providence-class carrier/destroyer", "Trade Federation cruiser", "48247", "capital ship" },
                    { 61, "50000", "56 days", "1000000", new DateTime(2014, 12, 20, 19, 48, 40, 409, DateTimeKind.Utc), "5", new DateTime(2014, 12, 20, 21, 23, 49, 944, DateTimeKind.Utc), "1.0", "https://starships.blob.core.windows.net/starship-api/61.jpeg", "18.5", "unknown", "Cygnus Spaceworks", "2000", "Theta-class T-2c shuttle", "Theta-class T-2c shuttle", "16", "transport" },
                    { 63, "20000000", "2 years", "59000000", new DateTime(2014, 12, 20, 19, 52, 56, 232, DateTimeKind.Utc), "7400", new DateTime(2014, 12, 20, 21, 23, 49, 946, DateTimeKind.Utc), "1.0", "https://starships.blob.core.windows.net/starship-api/63.jpeg", "1137", "unknown", "Kuat Drive Yards, Allanteen Six shipyards", "975", "Senator-class Star Destroyer", "Republic attack cruiser", "2000", "star destroyer" },
                    { 64, "unknown", "unknown", "unknown", new DateTime(2014, 12, 20, 19, 55, 15, 396, DateTimeKind.Utc), "3", new DateTime(2014, 12, 20, 21, 23, 49, 948, DateTimeKind.Utc), "0.5", "https://starships.blob.core.windows.net/starship-api/64.jpeg", "29.2", "unknown", "Theed Palace Space Vessel Engineering Corps/Nubia Star Drives, Incorporated", "1050", "J-type star skiff", "Naboo star skiff", "3", "yacht" },
                    { 65, "60", "2 days", "320000", new DateTime(2014, 12, 20, 19, 56, 57, 468, DateTimeKind.Utc), "1", new DateTime(2014, 12, 20, 21, 23, 49, 951, DateTimeKind.Utc), "1.0", "https://starships.blob.core.windows.net/starship-api/65.jpeg", "5.47", "unknown", "Kuat Systems Engineering", "1500", "Eta-2 Actis-class light interceptor", "Jedi Interceptor", "0", "starfighter" },
                    { 66, "110", "5 days", "155000", new DateTime(2014, 12, 20, 20, 3, 48, 603, DateTimeKind.Utc), "3", new DateTime(2014, 12, 20, 21, 23, 49, 953, DateTimeKind.Utc), "1.0", "https://starships.blob.core.windows.net/starship-api/66.jpeg", "14.5", "100", "Incom Corporation, Subpro Corporation", "1000", "Aggressive Reconnaissance-170 starfighte", "arc-170", "0", "starfighter" },
                    { 68, "40000000", "2 years", "57000000", new DateTime(2014, 12, 20, 20, 7, 11, 538, DateTimeKind.Utc), "200", new DateTime(2014, 12, 20, 21, 23, 49, 956, DateTimeKind.Utc), "1.0", "https://starships.blob.core.windows.net/starship-api/68.jpeg", "825", "unknown", "Hoersch-Kessel Drive, Inc, Gwori Revolutionary Industries", "unknown", "Munificent-class star frigate", "Banking clan frigte", "unknown", "cruiser" },
                    { 74, "140", "7 days", "168000", new DateTime(2014, 12, 20, 20, 38, 5, 31, DateTimeKind.Utc), "1", new DateTime(2014, 12, 20, 21, 23, 49, 959, DateTimeKind.Utc), "6", "https://starships.blob.core.windows.net/starship-api/74.jpeg", "6.71", "unknown", "Feethan Ottraw Scalable Assemblies", "1100", "Belbullab-22 starfighter", "Belbullab-22 starfighter", "0", "starfighter" },
                    { 75, "60", "15 hours", "102500", new DateTime(2014, 12, 20, 20, 43, 4, 349, DateTimeKind.Utc), "1", new DateTime(2014, 12, 20, 21, 23, 49, 961, DateTimeKind.Utc), "1.0", "https://starships.blob.core.windows.net/starship-api/75.jpeg", "7.9", "unknown", "Kuat Systems Engineering", "1050", "Alpha-3 Nimbus-class V-wing starfighter", "V-wing", "0", "starfighter" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FilmStarship_StarshipsId",
                table: "FilmStarship",
                column: "StarshipsId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonStarship_StarshipsId",
                table: "PersonStarship",
                column: "StarshipsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FilmStarship");

            migrationBuilder.DropTable(
                name: "PersonStarship");

            migrationBuilder.DropTable(
                name: "Films");

            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropTable(
                name: "Starships");
        }
    }
}
