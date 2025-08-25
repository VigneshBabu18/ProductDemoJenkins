
namespace ProductManagementApp.Models
{
    public class Product
    {
        public int Id { get; set; } // Unique identifier
        public string? Name { get; set; }
        public decimal? Price { get; set; }
        public string? Category { get; set; }
    }
}
