using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EToolService.Model.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string ImageLocation { get; set; }
        public byte[] Image { get; set; }
        public string Description { get; set; }
        public string Condition { get; set; }
        public decimal Discount { get; set; }
        public bool Active { get; set; }
        private string DiscountAsString()
        {
            return Math.Round(Discount * 100, 0).ToString();
        }
        public string GetDiscount
        { 
            get { return DiscountAsString(); } 
        }      
        public override bool Equals(object obj)
        {
            var right = obj as Product;
            return Id == right.Id;
        }
    }
}
