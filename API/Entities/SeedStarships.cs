using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public static class SeedStarships
    {
        public static Starship[] Load()
        {
            return
        new Starship[] {
            new Starship {
            Id = 2,
            Name = "CR90 corvette",
            Model = "CR90 corvette",
            Manufacturer = "Corellian Engineering Corporation",
            CostInCredits = "3500000",
            Length = "150",
            MaxAtmospheringSpeed = "950",
            Crew = "30-165",
            Passengers = "600",
            CargoCapacity = "3000000",
            Consumables = "1 year",
            HyperdriveRating = "2.0",
            MGLT = "60",
            StarshipClass = "corvette",
            // Films = new [] {
            //     "https://swapi.dev/api/films/1/",
            //     "https://swapi.dev/api/films/3/",
            //     "https://swapi.dev/api/films/6/"
            // },
            Created = DateTimeOffset.Parse("2014-12-10T14:20:33.369000Z").DateTime,
            Edited = DateTimeOffset.Parse("2014-12-20T21:23:49.867000Z").DateTime
        },
        new Starship
            {
                Id = 3,
                Name = "Star Destroyer",
                Model = "Imperial I-class Star Destroyer",
                Manufacturer = "Kuat Drive Yards",
                CostInCredits = "150000000",
                Length = "1,600",
                MaxAtmospheringSpeed = "975",
                Crew = "47,060",
                Passengers = "n/a",
                CargoCapacity = "36000000",
                Consumables = "2 years",
                HyperdriveRating = "2.0",
                MGLT = "60",
                StarshipClass = "Star Destroyer",
                // Films = new [] {
                // "https://swapi.dev/api/films/1/",
                // "https://swapi.dev/api/films/2/",
                // "https://swapi.dev/api/films/3/"
                // },
                Created = DateTimeOffset.Parse("2014-12-10T15:08:19.848000Z").DateTime,
                Edited = DateTimeOffset.Parse("2014-12-20T21:23:49.870000Z").DateTime,
            },
            new Starship
            {
                Id = 5,
                Name = "Sentinel-class landing craft",
                Model = "Sentinel-class landing craft",
                Manufacturer = "Sienar Fleet Systems, Cyngus Spaceworks",
                CostInCredits = "240000",
                Length = "38",
                MaxAtmospheringSpeed = "1000",
                Crew = "5",
                Passengers = "75",
                CargoCapacity = "180000",
                Consumables = "1 month",
                HyperdriveRating = "1.0",
                MGLT = "70",
                StarshipClass = "landing craft",
                // Films = new [] {
                // "https://swapi.dev/api/films/1/"
                // },
                Created = DateTimeOffset.Parse("2014-12-10T15:48:00.586000Z").DateTime,
                Edited = DateTimeOffset.Parse("2014-12-20T21:23:49.873000Z").DateTime,
            },
            new Starship
            {
                Id = 9,
                Name = "Death Star",
                Model = "DS-1 Orbital Battle Station",
                Manufacturer = "Imperial Department of Military Research, Sienar Fleet Systems",
                CostInCredits = "1000000000000",
                Length = "120000",
                MaxAtmospheringSpeed = "n/a",
                Crew = "342,953",
                Passengers = "843,342",
                CargoCapacity = "1000000000000",
                Consumables = "3 years",
                HyperdriveRating = "4.0",
                MGLT = "10",
                StarshipClass = "Deep Space Mobile Battlestation",
                // Films = new [] {
                // "https://swapi.dev/api/films/1/"
                // },
                Created = DateTimeOffset.Parse("2014-12-10T16:36:50.509000Z").DateTime,
                Edited = DateTimeOffset.Parse("2014-12-20T21:26:24.783000Z").DateTime,
            },
            new Starship
            {
                Id = 10,
                Name = "Millennium Falcon",
                Model = "YT-1300 light freighter",
                Manufacturer = "Corellian Engineering Corporation",
                CostInCredits = "100000",
                Length = "34.37",
                MaxAtmospheringSpeed = "1050",
                Crew = "4",
                Passengers = "6",
                CargoCapacity = "100000",
                Consumables = "2 months",
                HyperdriveRating = "0.5",
                MGLT = "75",
                StarshipClass = "Light freighter",
            //     Pilots = [
            //     "https://swapi.dev/api/people/13/",
            //     "https://swapi.dev/api/people/14/",
            //     "https://swapi.dev/api/people/25/",
            //     "https://swapi.dev/api/people/31/"
            // ],
            //     Films = new [] {
            //     "https://swapi.dev/api/films/1/",
            //     "https://swapi.dev/api/films/2/",
            //     "https://swapi.dev/api/films/3/"
            //     },
                Created = DateTimeOffset.Parse("2014-12-10T16:59:45.094000Z").DateTime,
                Edited = DateTimeOffset.Parse("2014-12-20T21:23:49.880000Z").DateTime,
            },
            new Starship
            {
                Id = 11,
                Name = "Y-wing",
                Model = "BTL Y-wing",
                Manufacturer = "Koensayr Manufacturing",
                CostInCredits = "134999",
                Length = "14",
                MaxAtmospheringSpeed = "1000km",
                Crew = "2",
                Passengers = "0",
                CargoCapacity = "110",
                Consumables = "1 week",
                HyperdriveRating = "1.0",
                MGLT = "80",
                StarshipClass = "assault starfighter",
                // Pilots = [],
                // Films = new [] {
                // "https://swapi.dev/api/films/1/",
                // "https://swapi.dev/api/films/2/",
                // "https://swapi.dev/api/films/3/"
                // },
                Created = DateTimeOffset.Parse("2014-12-12T11:00:39.817000Z").DateTime,
                Edited = DateTimeOffset.Parse("2014-12-20T21:23:49.883000Z").DateTime,
            },
            new Starship
            {
                Id = 12,
                Name = "X-wing",
                Model = "T-65 X-wing",
                Manufacturer = "Incom Corporation",
                CostInCredits = "149999",
                Length = "12.5",
                MaxAtmospheringSpeed = "1050",
                Crew = "1",
                Passengers = "0",
                CargoCapacity = "110",
                Consumables = "1 week",
                HyperdriveRating = "1.0",
                MGLT = "100",
                StarshipClass = "Starfighter",
                // Pilots = new [] {
                // "https://swapi.dev/api/people/1/",
                // "https://swapi.dev/api/people/9/",
                // "https://swapi.dev/api/people/18/",
                // "https://swapi.dev/api/people/19/"
                // },
                // Films = new [] {
                // "https://swapi.dev/api/films/1/",
                // "https://swapi.dev/api/films/2/",
                // "https://swapi.dev/api/films/3/"
                // },
                Created = DateTimeOffset.Parse("2014-12-12T11:19:05.340000Z").DateTime,
                Edited = DateTimeOffset.Parse("2014-12-20T21:23:49.886000Z").DateTime,
            },
            new Starship
            {
                Id = 13,
                Name = "TIE Advanced x1",
                Model = "Twin Ion Engine Advanced x1",
                Manufacturer = "Sienar Fleet Systems",
                CostInCredits = "unknown",
                Length = "9.2",
                MaxAtmospheringSpeed = "1200",
                Crew = "1",
                Passengers = "0",
                CargoCapacity = "150",
                Consumables = "5 days",
                HyperdriveRating = "1.0",
                MGLT = "105",
                StarshipClass = "Starfighter",
                // Pilots = new [] {
                // "https://swapi.dev/api/people/4/"
                // },
                // Films = new [] {
                // "https://swapi.dev/api/films/1/"
                // },
                Created = DateTimeOffset.Parse("2014-12-12T11:21:32.991000Z").DateTime,
                Edited = DateTimeOffset.Parse("2014-12-20T21:23:49.889000Z").DateTime,
            },
            new Starship
            {
                Id = 15,
                Name = "Executor",
                Model = "Executor-class star dreadnought",
                Manufacturer = "Kuat Drive Yards, Fondor Shipyards",
                CostInCredits = "1143350000",
                Length = "19000",
                MaxAtmospheringSpeed = "n/a",
                Crew = "279,144",
                Passengers = "38000",
                CargoCapacity = "250000000",
                Consumables = "6 years",
                HyperdriveRating = "2.0",
                MGLT = "40",
                StarshipClass = "Star dreadnought",
                // Films = new [] {
                // "https://swapi.dev/api/films/2/",
                // "https://swapi.dev/api/films/3/"
                // },
                Created = DateTimeOffset.Parse("2014-12-15T12:31:42.547000Z").DateTime,
                Edited = DateTimeOffset.Parse("2014-12-20T21:23:49.893000Z").DateTime,
            },
            new Starship
            {
                Id = 17,
                Name = "Rebel transport",
                Model = "GR-75 medium transport",
                Manufacturer = "Gallofree Yards, Inc.",
                CostInCredits = "unknown",
                Length = "90",
                MaxAtmospheringSpeed = "650",
                Crew = "6",
                Passengers = "90",
                CargoCapacity = "19000000",
                Consumables = "6 months",
                HyperdriveRating = "4.0",
                MGLT = "20",
                StarshipClass = "Medium transport",
                // Films = new [] {
                // "https://swapi.dev/api/films/2/",
                // "https://swapi.dev/api/films/3/"
                // },
                Created = DateTimeOffset.Parse("2014-12-15T12:34:52.264000Z").UtcDateTime,
                Edited = DateTimeOffset.Parse("2014-12-20T21:23:49.895000Z").UtcDateTime,
            }};
        }
    }
}