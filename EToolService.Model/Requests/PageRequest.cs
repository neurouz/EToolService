using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EToolService.Model.Requests
{
    public class PageRequest
    {
        public int Page { get; set; } = -1;
        public int ItemsPerPage { get; set; }
    }
}
