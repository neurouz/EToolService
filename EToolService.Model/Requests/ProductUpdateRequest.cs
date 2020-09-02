using System;
using System.Collections.Generic;
using System.Text;

namespace EToolService.Model.Requests
{
    public class ProductUpdateRequest
    {
        public string ProductName { get; set; }
        public double Price { get; set; }
        public byte[] Image { get; set; }
        public string ImageFileName { get; set; }
        public string Description { get; set; }
        public string Condition { get; set; }
        public double Discount { get; set; }
    }
}
