using System;
using System.Collections.Generic;

namespace EToolService.WebAPI.Database
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string ImageLocation { get; set; }
        public string Description { get; set; }
        public string Condition { get; set; }
        public double Discount { get; set; }
        public bool? Active { get; set; }
    }
}
