using System;
using System.Collections.Generic;
using System.Text;

namespace EToolService.Model.Requests
{
    public class ProductSearchRequest : PageRequest
    {
        public override string ToString()
        {
            return $"Page={Page}&ItemsPerPage={ItemsPerPage}";
        }
    }
}
