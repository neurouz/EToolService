using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EToolService.Model.Requests
{
    public class OrderInsertRequest
    {
        public string ShippingAddress { get; set; }
        public string ContactNumber { get; set; }
        public int CustomerId { get; set; }

        public List<int> Products { get; set; } = new List<int>();
        public List<int> Quantities { get; set; } = new List<int>();
    }
}
