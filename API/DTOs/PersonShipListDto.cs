namespace API.DTOs
{
    public class PersonShipListDto
    {
        public int StarshipId { get; set; }

        public List<int> PersonIds { get; set; } = new();
    }
}