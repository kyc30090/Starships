using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace API.DTOs
{
    public class StarshipUpdateDto
    {

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Model { get; set; }
        public string Manufacturer { get; set; }
       [FromForm(Name = "cost_in_credits")]
        public string CostInCredits { get; set; }
        public string Length { get; set; }
        [FromForm(Name = "max_atmosphering_speed")]
        public string MaxAtmospheringSpeed { get; set; }
        public string Crew { get; set; }
        public string Passengers { get; set; }
        [FromForm(Name = "cargo_capacity")]
        public string CargoCapacity { get; set; }
        public string Consumables { get; set; }
        [FromForm(Name = "hyperdrive_rating")]
        public string HyperdriveRating { get; set; }
        public string MGLT { get; set; }
        [FromForm(Name = "starship_class")]
        public string StarshipClass { get; set; }
        // public ICollection<int> PilotIds { get; set; } = new List<int>();
        public ICollection<int> FilmIds { get; set; } = new List<int>();

        public IFormFile File { get; set; }

    }
}