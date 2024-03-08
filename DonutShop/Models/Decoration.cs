using System.ComponentModel.DataAnnotations;

namespace DonutShop.Models
{
    public class Decoration
    {
        [Key]
        public Guid Id { get; set; } 
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string GetPriceFormatted() => Price.ToString("0.00");

    }
}
