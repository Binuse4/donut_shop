using System.ComponentModel.DataAnnotations;

namespace DonutShop.Models
{
    public class Order
    {
        [Key] public Guid OrderId { get; set; } 

        public string UserId { get; set; }

        public DateTime CreatedTime { get; set; }

        public Address DeliveryAddress { get; set; } = new Address();

        public List<Donut> Donuts { get; set; } = new List<Donut>();

        public decimal GetTotalPrice() => Donuts.Sum(don => don.GetTotalPrice());

        public string GetFormattedTotalPrice() => GetTotalPrice().ToString("0.00");
    }
}
