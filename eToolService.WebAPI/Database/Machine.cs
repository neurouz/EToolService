using System;
using System.Collections.Generic;

namespace EToolService.WebAPI.Database
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
