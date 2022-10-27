namespace WebApplication2.Models
{
    public class Catigorie
    {
        public int Id { get; set; }

        public string? ImageUrl { get; set; }

        public string? Name { get; set; }

        public List<Dress>? Dresses { get; set; } 
    }
}
