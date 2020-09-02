using System;
using System.Collections.Generic;
using System.Text;

namespace EToolService.Model.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string AreaName { get; set; }
        public bool Active { get; set; }
        public Model.Models.Account Account { get; set; }
    }
}
