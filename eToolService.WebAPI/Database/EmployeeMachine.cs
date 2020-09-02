using System;
using System.Collections.Generic;

namespace EToolService.WebAPI.Database
{
    public class EmployeeMachine
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int MachineId { get; set; }
        public string Level { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Machine Machine { get; set; }
    }
}
