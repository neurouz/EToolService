using System;
using System.Collections.Generic;

namespace EToolService.WebAPI.Database
{
    public class EmployeeRequest
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public string Description { get; set; }
        public string Purpose { get; set; }
        public int Phase { get; set; }
        public int EmployeeId { get; set; }
        public int AdministratorId { get; set; }

        public virtual Administrator Administrator { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
