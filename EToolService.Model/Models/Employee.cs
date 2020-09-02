using System;
using System.Collections.Generic;
using System.Text;

namespace EToolService.Model.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public DateTime ContractSigned { get; set; }
        public decimal Salary { get; set; }
        public bool? Active { get; set; }
        public List<Machine> Machines { get; set; } = new List<Machine>();
        public List<Request> Requests { get; set; } = new List<Request>();
        public string FullName { get
            {
                return FirstName + " " + LastName;
            } }
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}