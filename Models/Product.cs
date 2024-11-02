﻿using System.ComponentModel.DataAnnotations.Schema;

namespace SupermarketWEB_origins.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        [Column(TypeName = "decimal(6,0)")]
        public decimal Price { get; set; }

        public int Stock { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
