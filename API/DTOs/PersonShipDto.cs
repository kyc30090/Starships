using System.Text.Json.Serialization;

namespace API.DTOs
{
    public class PersonShipDto
    {
       [JsonPropertyName("person_id")]
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string Url { get { return $"https://swapi.dev/api/people/{PersonId}/"; } }
    }
}