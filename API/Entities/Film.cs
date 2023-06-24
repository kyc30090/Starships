using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace API.Entities
{
    public class Film
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        [JsonPropertyName("episode_id")]
        public int EpisodeId { get; set; }
        [JsonPropertyName("opening_crawl")]
        public string OpeningCrawl { get; set;}
        public string Url { get { return $"https://swapi.dev/api/films/{Id}/"; } }
    }
}