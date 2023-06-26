using System.Text.Json.Serialization;

namespace API.DTOs
{
    public class StarshipDto
    {
    public int Id { get; set; }
    public string Name { get; set; }
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
    
    public DateTime Created { get; set; }
    public DateTime? Edited { get; set; }
    public string Url { get { return $"https://swapi.dev/api/starships/{Id}/"; } }
    public string Image { get; set; }

    public List<FilmShipDto> Films { get; set; } = new ();
    }
}