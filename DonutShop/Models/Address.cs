﻿using System.ComponentModel.DataAnnotations;

namespace DonutShop.Models
{
    public class Address
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Line1 { get; set; }

        public string Line2 { get; set; }

        public string City { get; set; }

        public string Region { get; set; }

        public string PostalCode { get; set; }
    }
}
