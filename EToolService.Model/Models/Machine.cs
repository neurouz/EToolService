using System;
using System.Collections.Generic;
using System.Text;

namespace EToolService.Model.Models
{
    public class Machine
    {
        public int Id { get; set; }
        public string MachineName { get; set; }
        public string MachineDescription { get; set; }
        public string Purpose { get; set; }
        public string Type { get; set; }
    }
}
