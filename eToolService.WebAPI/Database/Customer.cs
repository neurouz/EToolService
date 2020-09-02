using System;
using System.Collections.Generic;

namespace EToolService.WebAPI.Database
{
    public class Customer
    {
        public Customer()
        {
            Order = new HashSet<Order>();
            Service = new HashSet<Service>();
        }

        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public int AreaId { get; set; }
        public int AccountId { get; set; }
        public bool? Active { get; set; }

        public virtual Account Account { get; set; }
        public virtual Area Area { get; set; }
        public virtual ICollection<Order> Order { get; set; }
        public virtual ICollection<Service> Service { get; set; }
    }
}
