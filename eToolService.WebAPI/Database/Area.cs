using System;
using System.Collections.Generic;

namespace EToolService.WebAPI.Database
{
    public class Area
    {
        public Area()
        {
            Customer = new HashSet<Customer>();
        }

        public int Id { get; set; }
        public string AreaName { get; set; }

        public virtual ICollection<Customer> Customer { get; set; }
    }
}
