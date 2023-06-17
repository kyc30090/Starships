﻿// <auto-generated />
using System;
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230617133804_InitialSeedStarships")]
    partial class InitialSeedStarships
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.7");

            modelBuilder.Entity("API.Entities.Starship", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CargoCapacity")
                        .HasColumnType("TEXT")
                        .HasAnnotation("Relational:JsonPropertyName", "cargo_capacity");

                    b.Property<string>("Consumables")
                        .HasColumnType("TEXT");

                    b.Property<string>("CostInCredits")
                        .HasColumnType("TEXT")
                        .HasAnnotation("Relational:JsonPropertyName", "cost_in_credits");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("Crew")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Edited")
                        .HasColumnType("TEXT");

                    b.Property<string>("HyperdriveRating")
                        .HasColumnType("TEXT")
                        .HasAnnotation("Relational:JsonPropertyName", "hyperdrive_rating");

                    b.Property<string>("Image")
                        .HasColumnType("TEXT");

                    b.Property<string>("Length")
                        .HasColumnType("TEXT");

                    b.Property<string>("MGLT")
                        .HasColumnType("TEXT")
                        .HasAnnotation("Relational:JsonPropertyName", "MGLT");

                    b.Property<string>("Manufacturer")
                        .HasColumnType("TEXT");

                    b.Property<string>("MaxAtmospheringSpeed")
                        .HasColumnType("TEXT")
                        .HasAnnotation("Relational:JsonPropertyName", "max_atmosphering_speed");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Passengers")
                        .HasColumnType("TEXT");

                    b.Property<string>("StarshipClass")
                        .HasColumnType("TEXT")
                        .HasAnnotation("Relational:JsonPropertyName", "starship_class");

                    b.HasKey("Id");

                    b.ToTable("Starships");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            CargoCapacity = "3000000",
                            Consumables = "1 year",
                            CostInCredits = "3500000",
                            Created = new DateTime(2014, 12, 10, 14, 20, 33, 369, DateTimeKind.Unspecified),
                            Crew = "30-165",
                            Edited = new DateTime(2014, 12, 20, 21, 23, 49, 867, DateTimeKind.Unspecified),
                            HyperdriveRating = "2.0",
                            Length = "150",
                            MGLT = "60",
                            Manufacturer = "Corellian Engineering Corporation",
                            MaxAtmospheringSpeed = "950",
                            Model = "CR90 corvette",
                            Name = "CR90 corvette",
                            Passengers = "600",
                            StarshipClass = "corvette"
                        },
                        new
                        {
                            Id = 3,
                            CargoCapacity = "36000000",
                            Consumables = "2 years",
                            CostInCredits = "150000000",
                            Created = new DateTime(2014, 12, 10, 15, 8, 19, 848, DateTimeKind.Unspecified),
                            Crew = "47,060",
                            Edited = new DateTime(2014, 12, 20, 21, 23, 49, 870, DateTimeKind.Unspecified),
                            HyperdriveRating = "2.0",
                            Length = "1,600",
                            MGLT = "60",
                            Manufacturer = "Kuat Drive Yards",
                            MaxAtmospheringSpeed = "975",
                            Model = "Imperial I-class Star Destroyer",
                            Name = "Star Destroyer",
                            Passengers = "n/a",
                            StarshipClass = "Star Destroyer"
                        },
                        new
                        {
                            Id = 5,
                            CargoCapacity = "180000",
                            Consumables = "1 month",
                            CostInCredits = "240000",
                            Created = new DateTime(2014, 12, 10, 15, 48, 0, 586, DateTimeKind.Unspecified),
                            Crew = "5",
                            Edited = new DateTime(2014, 12, 20, 21, 23, 49, 873, DateTimeKind.Unspecified),
                            HyperdriveRating = "1.0",
                            Length = "38",
                            MGLT = "70",
                            Manufacturer = "Sienar Fleet Systems, Cyngus Spaceworks",
                            MaxAtmospheringSpeed = "1000",
                            Model = "Sentinel-class landing craft",
                            Name = "Sentinel-class landing craft",
                            Passengers = "75",
                            StarshipClass = "landing craft"
                        },
                        new
                        {
                            Id = 9,
                            CargoCapacity = "1000000000000",
                            Consumables = "3 years",
                            CostInCredits = "1000000000000",
                            Created = new DateTime(2014, 12, 10, 16, 36, 50, 509, DateTimeKind.Unspecified),
                            Crew = "342,953",
                            Edited = new DateTime(2014, 12, 20, 21, 26, 24, 783, DateTimeKind.Unspecified),
                            HyperdriveRating = "4.0",
                            Length = "120000",
                            MGLT = "10",
                            Manufacturer = "Imperial Department of Military Research, Sienar Fleet Systems",
                            MaxAtmospheringSpeed = "n/a",
                            Model = "DS-1 Orbital Battle Station",
                            Name = "Death Star",
                            Passengers = "843,342",
                            StarshipClass = "Deep Space Mobile Battlestation"
                        },
                        new
                        {
                            Id = 10,
                            CargoCapacity = "100000",
                            Consumables = "2 months",
                            CostInCredits = "100000",
                            Created = new DateTime(2014, 12, 10, 16, 59, 45, 94, DateTimeKind.Unspecified),
                            Crew = "4",
                            Edited = new DateTime(2014, 12, 20, 21, 23, 49, 880, DateTimeKind.Unspecified),
                            HyperdriveRating = "0.5",
                            Length = "34.37",
                            MGLT = "75",
                            Manufacturer = "Corellian Engineering Corporation",
                            MaxAtmospheringSpeed = "1050",
                            Model = "YT-1300 light freighter",
                            Name = "Millennium Falcon",
                            Passengers = "6",
                            StarshipClass = "Light freighter"
                        },
                        new
                        {
                            Id = 11,
                            CargoCapacity = "110",
                            Consumables = "1 week",
                            CostInCredits = "134999",
                            Created = new DateTime(2014, 12, 12, 11, 0, 39, 817, DateTimeKind.Unspecified),
                            Crew = "2",
                            Edited = new DateTime(2014, 12, 20, 21, 23, 49, 883, DateTimeKind.Unspecified),
                            HyperdriveRating = "1.0",
                            Length = "14",
                            MGLT = "80",
                            Manufacturer = "Koensayr Manufacturing",
                            MaxAtmospheringSpeed = "1000km",
                            Model = "BTL Y-wing",
                            Name = "Y-wing",
                            Passengers = "0",
                            StarshipClass = "assault starfighter"
                        },
                        new
                        {
                            Id = 12,
                            CargoCapacity = "110",
                            Consumables = "1 week",
                            CostInCredits = "149999",
                            Created = new DateTime(2014, 12, 12, 11, 19, 5, 340, DateTimeKind.Unspecified),
                            Crew = "1",
                            Edited = new DateTime(2014, 12, 20, 21, 23, 49, 886, DateTimeKind.Unspecified),
                            HyperdriveRating = "1.0",
                            Length = "12.5",
                            MGLT = "100",
                            Manufacturer = "Incom Corporation",
                            MaxAtmospheringSpeed = "1050",
                            Model = "T-65 X-wing",
                            Name = "X-wing",
                            Passengers = "0",
                            StarshipClass = "Starfighter"
                        },
                        new
                        {
                            Id = 13,
                            CargoCapacity = "150",
                            Consumables = "5 days",
                            CostInCredits = "unknown",
                            Created = new DateTime(2014, 12, 12, 11, 21, 32, 991, DateTimeKind.Unspecified),
                            Crew = "1",
                            Edited = new DateTime(2014, 12, 20, 21, 23, 49, 889, DateTimeKind.Unspecified),
                            HyperdriveRating = "1.0",
                            Length = "9.2",
                            MGLT = "105",
                            Manufacturer = "Sienar Fleet Systems",
                            MaxAtmospheringSpeed = "1200",
                            Model = "Twin Ion Engine Advanced x1",
                            Name = "TIE Advanced x1",
                            Passengers = "0",
                            StarshipClass = "Starfighter"
                        },
                        new
                        {
                            Id = 15,
                            CargoCapacity = "250000000",
                            Consumables = "6 years",
                            CostInCredits = "1143350000",
                            Created = new DateTime(2014, 12, 15, 12, 31, 42, 547, DateTimeKind.Unspecified),
                            Crew = "279,144",
                            Edited = new DateTime(2014, 12, 20, 21, 23, 49, 893, DateTimeKind.Unspecified),
                            HyperdriveRating = "2.0",
                            Length = "19000",
                            MGLT = "40",
                            Manufacturer = "Kuat Drive Yards, Fondor Shipyards",
                            MaxAtmospheringSpeed = "n/a",
                            Model = "Executor-class star dreadnought",
                            Name = "Executor",
                            Passengers = "38000",
                            StarshipClass = "Star dreadnought"
                        },
                        new
                        {
                            Id = 17,
                            CargoCapacity = "19000000",
                            Consumables = "6 months",
                            CostInCredits = "unknown",
                            Created = new DateTime(2014, 12, 15, 12, 34, 52, 264, DateTimeKind.Utc),
                            Crew = "6",
                            Edited = new DateTime(2014, 12, 20, 21, 23, 49, 895, DateTimeKind.Utc),
                            HyperdriveRating = "4.0",
                            Length = "90",
                            MGLT = "20",
                            Manufacturer = "Gallofree Yards, Inc.",
                            MaxAtmospheringSpeed = "650",
                            Model = "GR-75 medium transport",
                            Name = "Rebel transport",
                            Passengers = "90",
                            StarshipClass = "Medium transport"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
