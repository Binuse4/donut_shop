﻿using System.ComponentModel.DataAnnotations;

namespace DonutShop.Models
{
    public class Donut
    {
        public const int DefaultNumber = 2;
        public const int MinimumNumber = 4;
        public const int MediumNumber = 6;
        public const int MaximumNumber = 12;

        [Key] public Guid Id { get; set; }

        public int OrderId { get; set; }

        public DonutSpecial Special { get; set; }

        public int SpecialId { get; set; }

        public int Size { get; set; }

        public List<DonutDecoration> Decorations { get; set; }

        public decimal GetPriceByNumber()
        {
            return ((decimal)Size / (decimal)DefaultNumber) * Special.BasePrice;
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
