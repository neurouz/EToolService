using System;
using System.Collections.Generic;
using System.Text;

namespace EToolService.Model.Models
{
    public class Request
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public string Description { get; set; }
        public string Purpose { get; set; }
        public int Phase { get; set; }
        public int EmployeeId { get; set; }
        public int AdministratorId { get; set; }
    }
}
