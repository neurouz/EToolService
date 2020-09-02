using System;
using System.Collections.Generic;

namespace EToolService.WebAPI.Database
{
    public class Administrator
    {
        public Administrator()
        {
            EmployeeRequest = new HashSet<EmployeeRequest>();
            Material = new HashSet<Material>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int AccountId { get; set; }

        public virtual Account Account { get; set; }
        public virtual ICollection<EmployeeRequest> EmployeeRequest { get; set; }
        public virtual ICollection<Material> Material { get; set; }
    }
}
