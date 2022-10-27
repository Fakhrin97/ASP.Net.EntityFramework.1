namespace WebApplication2.Models
{
    public class Dress
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public Catigorie? Catigorie { get; set; }
        public int CatigorieId { get; set; }

        public double Price { get; set; }

        public string? ImageUrl { get; set; }


    }
}
