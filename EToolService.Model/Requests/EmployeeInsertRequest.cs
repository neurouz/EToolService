using System;
using System.Collections.Generic;
using System.Text;

namespace EToolService.Model.Requests
{
    public class EmployeeInsertRequest
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Position { get; set; }

        public string ContractSigned { get; set; } = DateTime.Now.ToString();

        public decimal Salary { get; set; }
    }
}
