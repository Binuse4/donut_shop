using System.ComponentModel.DataAnnotations;

namespace DonutShop.Models
{
    public class Donut
    {
        public const int InitialtNumber = 1;
        public const int DefaultNumber = 2;
        public const int MinimumNumber = 4;
        public const int MediumNumber = 6;
        public const int MaximumNumber = 12;

        [Key] 
        public int Id { get; set; }

        public int OrderId { get; set; }

        public DonutSpecial Special { get; set; }

        public int SpecialId { get; set; }

        public int Quantity { get; set; }

        public List<DonutDecoration> Decorations { get; set; }

        public decimal GetPriceByNumber()
        {
            return ((decimal)Quantity / (decimal)InitialtNumber) * Special.BasePrice;
        }

        public decimal GetTotalPrice()
        {
            return GetPriceByNumber();
        }

        public string GetTotalPriceFormatted()
        {
            return GetTotalPrice().ToString("0.00");
        }
    }
}
