namespace API.DTOs
{
    public class FilmShipListDto
    {
        public int StarshipId { get; set; }

        public List<int> FilmIds { get; set; } = new();
    }
}