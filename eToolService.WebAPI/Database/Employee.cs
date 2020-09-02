using System;
using System.Collections.Generic;

namespace EToolService.WebAPI.Database
{
    public class Employee
    {
        public Employee()
        {
            EmployeeRequest = new HashSet<EmployeeRequest>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public DateTime ContractSigned { get; set; }
        public decimal Salary { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<EmployeeRequest> EmployeeRequest { get; set; }
    }
}
