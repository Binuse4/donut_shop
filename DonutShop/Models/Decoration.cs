using System.ComponentModel.DataAnnotations;

namespace DonutShop.Models
{
    public class Decoration
    {
        [Key]
        public int Id { get; set; } 
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string GetPriceFormatted() => Price.ToString("0.00");

    }
}
