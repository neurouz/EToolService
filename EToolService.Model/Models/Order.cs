using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EToolService.Model.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string ShippingAddress { get; set; }
        public string ContactNumber { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public bool Active { get; set; }
        public List<KeyValuePair<int, Product>> Products { get; set; }
        public string Condition
        {
            get { return Active ? "Aktivna" : "Odobrena"; }
        }
        public string Total
        {
            get { return Sum(); }
        }
        private string Sum()
        {
            if (Products == null) return "";
            
            double sum = 0;
            foreach(var item in Products)
            {
                sum += (double)(item.Value.Price * (1 - item.Value.Discount)) * item.Key;
            }
            return Math.Round(sum, 2).ToString();
        }
    }
}
