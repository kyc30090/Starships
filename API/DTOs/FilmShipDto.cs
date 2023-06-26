using System.Text.Json.Serialization;

namespace API.DTOs
{
    public class FilmShipDto
    {
        [JsonPropertyName("film_id")]
        public int FilmId { get; set; }
        public string Title { get; set; }
        [JsonPropertyName("episode_id")]
        public int EpisodeId { get; set; }
        public string Url { get { return $"https://swapi.dev/api/films/{FilmId}/"; } }
    }
}