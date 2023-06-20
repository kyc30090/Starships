using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

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
        [JsonPropertyName("cost_in_credits")]
        public string CostInCredits { get; set; }
        public string Length { get; set; }
        [JsonPropertyName("max_atmosphering_speed")]
        public string MaxAtmospheringSpeed { get; set; }
        public string Crew { get; set; }
        public string Passengers { get; set; }
        [JsonPropertyName("cargo_capacity")]
        public string CargoCapacity { get; set; }
        public string Consumables { get; set; }
        [JsonPropertyName("hyperdrive_rating")]
        public string HyperdriveRating { get; set; }
        [JsonPropertyName("MGLT")]
        public string MGLT { get; set; }
        [JsonPropertyName("starship_class")]
        public string StarshipClass { get; set; }
        // public ICollection<string> Pilots { get; set; }
        // public ICollection<string> Films { get; set; }
        public DateTime Created { get; set; } = DateTime.UtcNow;
        public DateTime Edited { get; set; }
    }
}