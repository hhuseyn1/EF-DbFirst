using System;
using System.Collections.Generic;

namespace EF_DbFirst.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal UnitPrice { get; set; }
        public string? Description { get; set; }
    }
}
