using System;
using System.Collections.Generic;
using System.Text;

namespace EToolService.Model.Requests
{
    public class EmployeeUpdateRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public DateTime? ContractSigned { get; set; } = null;
        public decimal? Salary { get; set; }
        public bool? Active { get; set; }
    }
}
