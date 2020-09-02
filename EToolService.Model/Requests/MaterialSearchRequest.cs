using EToolService.Model.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EToolService.Model.Requests
{
    public class MaterialSearchRequest
    {
        public MaterialTypes type { get; set; }
        public bool isAvailable { get; set; } = true;
        public override string ToString()
        {
            return $"type={(int)type}&isAvailable={isAvailable}";
        }
    }
}
