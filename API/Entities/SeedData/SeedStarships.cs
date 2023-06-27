namespace API.Entities.SeedData
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
            Image = "https://starships.blob.core.windows.net/starship-api/2.jpeg",
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
                Image = "https://starships.blob.core.windows.net/starship-api/3.jpeg",
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
                Image = "https://starships.blob.core.windows.net/starship-api/5.jpeg",
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
                Image = "https://starships.blob.core.windows.net/starship-api/9.jpeg",
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
                Image = "https://starships.blob.core.windows.net/starship-api/10.jpeg",
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
                Image = "https://starships.blob.core.windows.net/starship-api/11.jpeg",
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
                Image = "https://starships.blob.core.windows.net/starship-api/12.jpeg",
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
                Image = "https://starships.blob.core.windows.net/starship-api/13.jpeg",
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
                Image = "https://starships.blob.core.windows.net/starship-api/15.jpeg",
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
                Image = "https://starships.blob.core.windows.net/starship-api/17.jpeg",
                Created = DateTimeOffset.Parse("2014-12-15T12:34:52.264000Z").UtcDateTime,
                Edited = DateTimeOffset.Parse("2014-12-20T21:23:49.895000Z").UtcDateTime,
            },

       new Starship {
            Name = "Slave 1",
            Model = "Firespray-31-class patrol and attack",
            Manufacturer = "Kuat Systems Engineering",
            CostInCredits = "unknown",
            Length = "21.5",
            MaxAtmospheringSpeed = "1000",
            Crew = "1",
            Passengers = "6",
            CargoCapacity = "70000",
            Consumables = "1 month",
            HyperdriveRating = "3.0",
            MGLT = "70",
            StarshipClass = "Patrol craft",
            // "pilots": [
            //     "https://swapi.dev/api/people/22/"
            // ],
            // "films": [
            //     "https://swapi.dev/api/films/2/",
            //     "https://swapi.dev/api/films/5/"
            // ],
			Created= DateTimeOffset.Parse("2014-12-15T13:00:56.332000Z").UtcDateTime,
            Edited= DateTimeOffset.Parse("2014-12-20T21:23:49.897000Z").UtcDateTime,
            Id = 21,
            Image = "https://starships.blob.core.windows.net/starship-api/21.jpeg"

        },
        new Starship {
            Name = "Imperial shuttle",
            Model = "Lambda-class T-4a shuttle",
            Manufacturer = "Sienar Fleet Systems",
            CostInCredits = "240000",
            Length = "20",
            MaxAtmospheringSpeed = "850",
            Crew = "6",
            Passengers = "20",
            CargoCapacity = "80000",
            Consumables = "2 months",
            HyperdriveRating = "1.0",
            MGLT = "50",
            StarshipClass = "Armed government transport",
			// "pilots": [
			// 	"https://swapi.dev/api/people/1/",
			// 	"https://swapi.dev/api/people/13/",
			// 	"https://swapi.dev/api/people/14/"
			// ],
			// "films": [
			// 	"https://swapi.dev/api/films/2/",
			// 	"https://swapi.dev/api/films/3/"
			// ],
			Created= DateTimeOffset.Parse("2014-12-15T13:04:47.235000Z").UtcDateTime,
            Edited= DateTimeOffset.Parse("2014-12-20T21:23:49.900000Z").UtcDateTime,
            Id = 22,
            Image = "https://starships.blob.core.windows.net/starship-api/22.jpeg"
        },
        new Starship {
            Name = "EF76 Nebulon-B escort frigate",
            Model = "EF76 Nebulon-B escort frigate",
            Manufacturer = "Kuat Drive Yards",
            CostInCredits = "8500000",
            Length = "300",
            MaxAtmospheringSpeed = "800",
            Crew = "854",
            Passengers = "75",
            CargoCapacity = "6000000",
            Consumables = "2 years",
            HyperdriveRating = "2.0",
            MGLT = "40",
            StarshipClass = "Escort ship",
			// "pilots": [],
			// "films": [
			// 	"https://swapi.dev/api/films/2/",
			// 	"https://swapi.dev/api/films/3/"
			// ],
			Created= DateTimeOffset.Parse("2014-12-15T13:06:30.813000Z").UtcDateTime,
            Edited= DateTimeOffset.Parse("2014-12-20T21:23:49.902000Z").UtcDateTime,
            Id = 23,
            Image = "https://starships.blob.core.windows.net/starship-api/23.jpeg"
        },
        new Starship
        {
            Name = "Calamari Cruiser",
            Model = "MC80 Liberty type Star Cruiser",
            Manufacturer = "Mon Calamari shipyards",
            CostInCredits = "104000000",
            Length = "1200",
            MaxAtmospheringSpeed = "n/a",
            Crew = "5400",
            Passengers = "1200",
            CargoCapacity = "unknown",
            Consumables = "2 years",
            HyperdriveRating = "1.0",
            MGLT = "60",
            StarshipClass = "Star Cruiser",
            // "pilots": [],
			// "films": [
			// 	"https://swapi.dev/api/films/3/"
			// ],
			Created= DateTimeOffset.Parse("2014-12-18T10:54:57.804000Z").UtcDateTime,
            Edited= DateTimeOffset.Parse("2014-12-20T21:23:49.904000Z").UtcDateTime,
            Id = 27,
            Image = "https://starships.blob.core.windows.net/starship-api/27.jpeg"
        },
        new Starship
        {
            Name = "A-wing",
            Model = "RZ-1 A-wing Interceptor",
            Manufacturer = "Alliance Underground Engineering, Incom Corporation",
            CostInCredits = "175000",
            Length = "9.6",
            MaxAtmospheringSpeed = "1300",
            Crew = "1",
            Passengers = "0",
            CargoCapacity = "40",
            Consumables = "1 week",
            HyperdriveRating = "1.0",
            MGLT = "120",
            StarshipClass = "Starfighter",
            // "pilots": [
            //     "https://swapi.dev/api/people/29/"
            // ],
			// "films": [
			// 	"https://swapi.dev/api/films/3/"
			// ],
			Created= DateTimeOffset.Parse("2014-12-18T11:16:34.542000Z").UtcDateTime,
            Edited= DateTimeOffset.Parse("2014-12-20T21:23:49.907000Z").UtcDateTime,
            Id = 28,
            Image = "https://starships.blob.core.windows.net/starship-api/28.jpeg"
        },
        new Starship
        {
            Name = "B-wing",
            Model = "A/SF-01 B-wing starfighter",
            Manufacturer = "Slayn & Korpil",
            CostInCredits = "220000",
            Length = "16.9",
            MaxAtmospheringSpeed = "950",
            Crew = "1",
            Passengers = "0",
            CargoCapacity = "45",
            Consumables = "1 week",
            HyperdriveRating = "2.0",
            MGLT = "91",
            StarshipClass = "Assault Starfighter",
            // "pilots": [],
			// "films": [
			// 	"https://swapi.dev/api/films/3/"
			// ],
			Created= DateTimeOffset.Parse("2014-12-18T11:18:04.763000Z").UtcDateTime,
            Edited= DateTimeOffset.Parse("2014-12-20T21:23:49.909000Z").UtcDateTime,
            Id = 29,
            Image = "https://starships.blob.core.windows.net/starship-api/29.jpeg"
        },
        new Starship
        {
            Name = "Republic Cruiser",
            Model = "Consular-class cruiser",
            Manufacturer = "Corellian Engineering Corporation",
            CostInCredits = "unknown",
            Length = "115",
            MaxAtmospheringSpeed = "900",
            Crew = "9",
            Passengers = "16",
            CargoCapacity = "unknown",
            Consumables = "unknown",
            HyperdriveRating = "2.0",
            MGLT = "unknown",
            StarshipClass = "Space cruiser",
            // "pilots": [],
			// "films": [
			// 	"https://swapi.dev/api/films/4/"
			// ],
			Created= DateTimeOffset.Parse("2014-12-19T17:01:31.488000Z").UtcDateTime,
            Edited= DateTimeOffset.Parse("2014-12-20T21:23:49.912000Z").UtcDateTime,
            Id = 31,
            Image = "https://starships.blob.core.windows.net/starship-api/31.jpeg"
        },
        new Starship
        {
            Name = "Droid control ship",
            Model = "Lucrehulk-class Droid Control Ship",
            Manufacturer = "Hoersch-Kessel Drive, Inc.",
            CostInCredits = "unknown",
            Length = "3170",
            MaxAtmospheringSpeed = "n/a",
            Crew = "175",
            Passengers = "139000",
            CargoCapacity = "4000000000",
            Consumables = "500 days",
            HyperdriveRating = "2.0",
            MGLT = "unknown",
            StarshipClass = "Droid control ship",
            // "pilots": [],
			// "films": [
			// 	"https://swapi.dev/api/films/4/",
			// 	"https://swapi.dev/api/films/5/",
			// 	"https://swapi.dev/api/films/6/"
			// ],
			Created= DateTimeOffset.Parse("2014-12-19T17:04:06.323000Z").UtcDateTime,
            Edited= DateTimeOffset.Parse("2014-12-20T21:23:49.915000Z").UtcDateTime,
            Id = 32,
            Image = "https://starships.blob.core.windows.net/starship-api/32.jpeg",
        },
        new Starship
        {
            Name = "Naboo fighter",
            Model = "N-1 starfighter",
            Manufacturer = "Theed Palace Space Vessel Engineering Corps",
            CostInCredits = "200000",
            Length = "11",
            MaxAtmospheringSpeed = "1100",
            Crew = "1",
            Passengers = "0",
            CargoCapacity = "65",
            Consumables = "7 days",
            HyperdriveRating = "1.0",
            MGLT = "unknown",
            StarshipClass = "Starfighter",
            // "pilots": [
            //     "https://swapi.dev/api/people/11/",¬
            //     "https://swapi.dev/api/people/35/",
            //     "https://swapi.dev/api/people/60/"
            // ],
			// "films": [
			// 	"https://swapi.dev/api/films/4/",
			// 	"https://swapi.dev/api/films/5/"
			// ],
			Created= DateTimeOffset.Parse("2014-12-19T17:39:17.582000Z").UtcDateTime,
            Edited= DateTimeOffset.Parse("2014-12-20T21:23:49.917000Z").UtcDateTime,
            Id = 39,
            Image = "https://starships.blob.core.windows.net/starship-api/39.jpeg"
        },
        new Starship
        {
            Name = "Naboo Royal Starship",
            Model = "J-type 327 Nubian royal starship",
            Manufacturer = "Theed Palace Space Vessel Engineering Corps, Nubia Star Drives",
            CostInCredits = "unknown",
            Length = "76",
            MaxAtmospheringSpeed = "920",
            Crew = "8",
            Passengers = "unknown",
            CargoCapacity = "unknown",
            Consumables = "unknown",
            HyperdriveRating = "1.8",
            MGLT = "unknown",
            StarshipClass = "yacht",
            // "pilots": [
            //     "https://swapi.dev/api/people/39/"
            // ],
			// "films": [
			// 	"https://swapi.dev/api/films/4/"
			// ],
			Created= DateTimeOffset.Parse("2014-12-19T17:45:03.506000Z").UtcDateTime,
            Edited= DateTimeOffset.Parse("2014-12-20T21:23:49.919000Z").UtcDateTime,
            Id = 40,
            Image = "https://starships.blob.core.windows.net/starship-api/40.jpeg"
        },
        new Starship
        {
            Name = "Scimitar",
            Model = "Star Courier",
            Manufacturer = "Republic Sienar Systems",
            CostInCredits = "55000000",
            Length = "26.5",
            MaxAtmospheringSpeed = "1180",
            Crew = "1",
            Passengers = "6",
            CargoCapacity = "2500000",
            Consumables = "30 days",
            HyperdriveRating = "1.5",
            MGLT = "unknown",
            StarshipClass = "Space Transport",
            // "pilots": [
            //     "https://swapi.dev/api/people/44/"
            // ],
			// "films": [
			// 	"https://swapi.dev/api/films/4/"
			// ],
			Created= DateTimeOffset.Parse("2014-12-20T09:39:56.116000Z").UtcDateTime,
            Edited= DateTimeOffset.Parse("2014-12-20T21:23:49.922000Z").UtcDateTime,
            Id = 41,
            Image = "https://starships.blob.core.windows.net/starship-api/41.jpeg"
        },
        new Starship
        {
            Name = "J-type diplomatic barge",
            Model = "J-type diplomatic barge",
            Manufacturer = "Theed Palace Space Vessel Engineering Corps, Nubia Star Drives",
            CostInCredits = "2000000",
            Length = "39",
            MaxAtmospheringSpeed = "2000",
            Crew = "5",
            Passengers = "10",
            CargoCapacity = "unknown",
            Consumables = "1 year",
            HyperdriveRating = "0.7",
            MGLT = "unknown",
            StarshipClass = "Diplomatic barge",
            // "pilots": [],
			// "films": [
			// 	"https://swapi.dev/api/films/5/"
			// ],
			Created= DateTimeOffset.Parse("2014-12-20T11:05:51.237000Z").UtcDateTime,
            Edited= DateTimeOffset.Parse("2014-12-20T21:23:49.925000Z").UtcDateTime,
            Id = 43,
            Image = "https://starships.blob.core.windows.net/starship-api/43.jpeg"
        },
        new Starship
        {
            Name = "AA-9 Coruscant freighter",
            Model = "Botajef AA-9 Freighter-Liner",
            Manufacturer = "Botajef Shipyards",
            CostInCredits = "unknown",
            Length = "390",
            MaxAtmospheringSpeed = "unknown",
            Crew = "unknown",
            Passengers = "30000",
            CargoCapacity = "unknown",
            Consumables = "unknown",
            HyperdriveRating = "unknown",
            MGLT = "unknown",
            StarshipClass = "freighter",
            // "pilots": [],
			// "films": [
			// 	"https://swapi.dev/api/films/5/"
			// ],
			Created= DateTimeOffset.Parse("2014-12-20T17:24:23.509000Z").UtcDateTime,
            Edited= DateTimeOffset.Parse("2014-12-20T21:23:49.928000Z").UtcDateTime,
            Id = 47,
            Image = "https://starships.blob.core.windows.net/starship-api/47.jpeg"
        },
        new Starship
        {
            Name = "Jedi starfighter",
            Model = "Delta-7 Aethersprite-class interceptor",
            Manufacturer = "Kuat Systems Engineering",
            CostInCredits = "180000",
            Length = "8",
            MaxAtmospheringSpeed = "1150",
            Crew = "1",
            Passengers = "0",
            CargoCapacity = "60",
            Consumables = "7 days",
            HyperdriveRating = "1.0",
            MGLT = "unknown",
            StarshipClass = "Starfighter",
            // "pilots": [
            //     "https://swapi.dev/api/people/10/",
            //     "https://swapi.dev/api/people/58/"
            // ],
			// "films": [
			// 	"https://swapi.dev/api/films/5/",
			// 	"https://swapi.dev/api/films/6/"
			// ],
			Created= DateTimeOffset.Parse("2014-12-20T17:35:23.906000Z").UtcDateTime,
            Edited= DateTimeOffset.Parse("2014-12-20T21:23:49.930000Z").UtcDateTime,
            Id = 48,
            Image = "https://starships.blob.core.windows.net/starship-api/48.jpeg"
        },
        new Starship
        {
            Name = "H-type Nubian yacht",
            Model = "H-type Nubian yacht",
            Manufacturer = "Theed Palace Space Vessel Engineering Corps",
            CostInCredits = "unknown",
            Length = "47.9",
            MaxAtmospheringSpeed = "8000",
            Crew = "4",
            Passengers = "unknown",
            CargoCapacity = "unknown",
            Consumables = "unknown",
            HyperdriveRating = "0.9",
            MGLT = "unknown",
            StarshipClass = "yacht",
            // "pilots": [
            //     "https://swapi.dev/api/people/35/"
            // ],
            // "films": [
            //     "https://swapi.dev/api/films/5/"
            // ],
			Created = DateTimeOffset.Parse("2014-12-20T17:46:46.847000Z").UtcDateTime,
            Edited = DateTimeOffset.Parse("2014-12-20T21:23:49.932000Z").UtcDateTime,
            Id = 49,
            Image = "https://starships.blob.core.windows.net/starship-api/49.jpeg"
        },
        new Starship
        {
            Name = "Republic Assault ship",
            Model = "Acclamator I-class assault ship",
            Manufacturer = "Rothana Heavy Engineering",
            CostInCredits = "unknown",
            Length = "752",
            MaxAtmospheringSpeed = "unknown",
            Crew = "700",
            Passengers = "16000",
            CargoCapacity = "11250000",
            Consumables = "2 years",
            HyperdriveRating = "0.6",
            MGLT = "unknown",
            StarshipClass = "assault ship",
            // "pilots": [],
			// "films": [
			// 	"https://swapi.dev/api/films/5/"
			// ],
			Created= DateTimeOffset.Parse("2014-12-20T18:08:42.926000Z").UtcDateTime,
            Edited= DateTimeOffset.Parse("2014-12-20T21:23:49.935000Z").UtcDateTime,
            Id = 52,
            Image = "https://starships.blob.core.windows.net/starship-api/52.jpeg"
        },
        new Starship
        {
            Name = "Solar Sailer",
            Model = "Punworcca 116-class interstellar sloop",
            Manufacturer = "Huppla Pasa Tisc Shipwrights Collective",
            CostInCredits = "35700",
            Length = "15.2",
            MaxAtmospheringSpeed = "1600",
            Crew = "3",
            Passengers = "11",
            CargoCapacity = "240",
            Consumables = "7 days",
            HyperdriveRating = "1.5",
            MGLT = "unknown",
            StarshipClass = "yacht",
            // "pilots": [],
			// "films": [
			// 	"https://swapi.dev/api/films/5/"
			// ],
			Created= DateTimeOffset.Parse("2014-12-20T18:37:56.969000Z").UtcDateTime,
            Edited= DateTimeOffset.Parse("2014-12-20T21:23:49.937000Z").UtcDateTime,
            Id = 58,
            Image = "https://starships.blob.core.windows.net/starship-api/58.jpeg"
        },
        new Starship
        {
            Name = "Trade Federation cruiser",
            Model = "Providence-class carrier/destroyer",
            Manufacturer = "Rendili StarDrive, Free Dac Volunteers Engineering corps.",
            CostInCredits = "125000000",
            Length = "1088",
            MaxAtmospheringSpeed = "1050",
            Crew = "600",
            Passengers = "48247",
            CargoCapacity = "50000000",
            Consumables = "4 years",
            HyperdriveRating = "1.5",
            MGLT = "unknown",
            StarshipClass = "capital ship",
            // "pilots": [
            //     "https://swapi.dev/api/people/10/",
            //     "https://swapi.dev/api/people/11/"
            // ],
			// "films": [
			// 	"https://swapi.dev/api/films/6/"
			// ],
			Created = DateTimeOffset.Parse("2014-12-20T19:40:21.902000Z").UtcDateTime,
            Edited = DateTimeOffset.Parse("2014-12-20T21:23:49.941000Z").UtcDateTime,
            Id = 59,
            Image = "https://starships.blob.core.windows.net/starship-api/59.jpeg"
        },
        new Starship
        {
            Name = "Theta-class T-2c shuttle",
            Model = "Theta-class T-2c shuttle",
            Manufacturer = "Cygnus Spaceworks",
            CostInCredits = "1000000",
            Length = "18.5",
            MaxAtmospheringSpeed = "2000",
            Crew = "5",
            Passengers = "16",
            CargoCapacity = "50000",
            Consumables = "56 days",
            HyperdriveRating = "1.0",
            MGLT = "unknown",
            StarshipClass = "transport",
            // "pilots": [],
			// "films": [
			// 	"https://swapi.dev/api/films/6/"
			// ],
			Created = DateTimeOffset.Parse("2014-12-20T19:48:40.409000Z").UtcDateTime,
            Edited = DateTimeOffset.Parse("2014-12-20T21:23:49.944000Z").UtcDateTime,
            Id = 61,
            Image = "https://starships.blob.core.windows.net/starship-api/61.jpeg"
        },
        new Starship
        {
            Name = "Republic attack cruiser",
            Model = "Senator-class Star Destroyer",
            Manufacturer = "Kuat Drive Yards, Allanteen Six shipyards",
            CostInCredits = "59000000",
            Length = "1137",
            MaxAtmospheringSpeed = "975",
            Crew = "7400",
            Passengers = "2000",
            CargoCapacity = "20000000",
            Consumables = "2 years",
            HyperdriveRating = "1.0",
            MGLT = "unknown",
            StarshipClass = "star destroyer",
            // "pilots": [],
			// "films": [
			// 	"https://swapi.dev/api/films/6/"
			// ],
			Created = DateTimeOffset.Parse("2014-12-20T19:52:56.232000Z").UtcDateTime,
            Edited = DateTimeOffset.Parse("2014-12-20T21:23:49.946000Z").UtcDateTime,
            Id = 63,
            Image = "https://starships.blob.core.windows.net/starship-api/63.jpeg"
        },
        new Starship
        {
            Name = "Naboo star skiff",
            Model = "J-type star skiff",
            Manufacturer = "Theed Palace Space Vessel Engineering Corps/Nubia Star Drives, Incorporated",
            CostInCredits = "unknown",
            Length = "29.2",
            MaxAtmospheringSpeed = "1050",
            Crew = "3",
            Passengers = "3",
            CargoCapacity = "unknown",
            Consumables = "unknown",
            HyperdriveRating = "0.5",
            MGLT = "unknown",
            StarshipClass = "yacht",
            // "pilots": [
            //     "https://swapi.dev/api/people/10/",
            //     "https://swapi.dev/api/people/35/"
            // ],
            // "films": [
            // 	"https://swapi.dev/api/films/6/"
            // ],
            Created = DateTimeOffset.Parse("2014-12-20T19:55:15.396000Z").UtcDateTime,
            Edited = DateTimeOffset.Parse("2014-12-20T21:23:49.948000Z").UtcDateTime,
            Id = 64,
            Image = "https://starships.blob.core.windows.net/starship-api/64.jpeg"
        },
        new Starship
        {
            Name = "Jedi Interceptor",
            Model = "Eta-2 Actis-class light interceptor",
            Manufacturer = "Kuat Systems Engineering",
            CostInCredits = "320000",
            Length = "5.47",
            MaxAtmospheringSpeed = "1500",
            Crew = "1",
            Passengers = "0",
            CargoCapacity = "60",
            Consumables = "2 days",
            HyperdriveRating = "1.0",
            MGLT = "unknown",
            StarshipClass = "starfighter",
            // "pilots": [
            //     "https://swapi.dev/api/people/10/",
            //     "https://swapi.dev/api/people/11/"
            // ],
            // "films": [
            // 	"https://swapi.dev/api/films/6/"
            // ],
            Created = DateTimeOffset.Parse("2014-12-20T19:56:57.468000Z").UtcDateTime,
            Edited = DateTimeOffset.Parse("2014-12-20T21:23:49.951000Z").UtcDateTime,
            Id = 65,
            Image = "https://starships.blob.core.windows.net/starship-api/65.jpeg"
        },
        new Starship
        {
            Name = "arc-170",
            Model = "Aggressive Reconnaissance-170 starfighte",
            Manufacturer = "Incom Corporation, Subpro Corporation",
            CostInCredits = "155000",
            Length = "14.5",
            MaxAtmospheringSpeed = "1000",
            Crew = "3",
            Passengers = "0",
            CargoCapacity = "110",
            Consumables = "5 days",
            HyperdriveRating = "1.0",
            MGLT = "100",
            StarshipClass = "starfighter",
            // "pilots": [],
            // "films": [
            // 	"https://swapi.dev/api/films/6/"
            // ],
            Created = DateTimeOffset.Parse("2014-12-20T20:03:48.603000Z").UtcDateTime,
            Edited = DateTimeOffset.Parse("2014-12-20T21:23:49.953000Z").UtcDateTime,
            Id = 66,
            Image = "https://starships.blob.core.windows.net/starship-api/66.jpeg"
        },
        new Starship
        {
            Name = "Banking clan frigte",
            Model = "Munificent-class star frigate",
            Manufacturer = "Hoersch-Kessel Drive, Inc, Gwori Revolutionary Industries",
            CostInCredits = "57000000",
            Length = "825",
            MaxAtmospheringSpeed = "unknown",
            Crew = "200",
            Passengers = "unknown",
            CargoCapacity = "40000000",
            Consumables = "2 years",
            HyperdriveRating = "1.0",
            MGLT = "unknown",
            StarshipClass = "cruiser",
            // "pilots": [],
            // "films": [
            // 	"https://swapi.dev/api/films/6/"
            // ],
            Created = DateTimeOffset.Parse("2014-12-20T20:07:11.538000Z").UtcDateTime,
            Edited = DateTimeOffset.Parse("2014-12-20T21:23:49.956000Z").UtcDateTime,
            Id = 68,
            Image = "https://starships.blob.core.windows.net/starship-api/68.jpeg"
        },
        new Starship
        {
            Name = "Belbullab-22 starfighter",
            Model = "Belbullab-22 starfighter",
            Manufacturer = "Feethan Ottraw Scalable Assemblies",
            CostInCredits = "168000",
            Length = "6.71",
            MaxAtmospheringSpeed = "1100",
            Crew = "1",
            Passengers = "0",
            CargoCapacity = "140",
            Consumables = "7 days",
            HyperdriveRating = "6",
            MGLT = "unknown",
            StarshipClass = "starfighter",
            // "pilots": [
            //     "https://swapi.dev/api/people/10/",
            //     "https://swapi.dev/api/people/79/"
            // ],
            // "films": [
            // 	"https://swapi.dev/api/films/6/"
            // ],
            Created = DateTimeOffset.Parse("2014-12-20T20:38:05.031000Z").UtcDateTime,
            Edited = DateTimeOffset.Parse("2014-12-20T21:23:49.959000Z").UtcDateTime,
            Id = 74,
            Image = "https://starships.blob.core.windows.net/starship-api/74.jpeg"
        },
        new Starship
        {
            Name = "V-wing",
            Model = "Alpha-3 Nimbus-class V-wing starfighter",
            Manufacturer = "Kuat Systems Engineering",
            CostInCredits = "102500",
            Length = "7.9",
            MaxAtmospheringSpeed = "1050",
            Crew = "1",
            Passengers = "0",
            CargoCapacity = "60",
            Consumables = "15 hours",
            HyperdriveRating = "1.0",
            MGLT = "unknown",
            StarshipClass = "starfighter",
            // "pilots": [],
            // "films": [
            // 	"https://swapi.dev/api/films/6/"
            // ],
            Created = DateTimeOffset.Parse("2014-12-20T20:43:04.349000Z").UtcDateTime,
            Edited = DateTimeOffset.Parse("2014-12-20T21:23:49.961000Z").UtcDateTime,
            Id = 75,
            Image = "https://starships.blob.core.windows.net/starship-api/75.jpeg"
        }
            };
        }
    }
}