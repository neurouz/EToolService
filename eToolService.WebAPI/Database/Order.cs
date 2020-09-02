using System;
using System.Collections.Generic;

namespace EToolService.WebAPI.Database
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string ShippingAddress { get; set; }
        public string ContactNumber { get; set; }
        public int CustomerId { get; set; }
        public bool? Active { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
