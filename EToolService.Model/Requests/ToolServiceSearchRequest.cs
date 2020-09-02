using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EToolService.Model.Requests
{
    public class ToolServiceSearchRequest : PageRequest
    {
        public int CustomerId { get; set; } = 0;
        public override string ToString()
        {
            return $"Page={Page}&ItemsPerPage={ItemsPerPage}&CustomerId={CustomerId}";
        }
    }
}
