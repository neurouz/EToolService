using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EToolService.Model.Requests
{
    public class OrderSearchRequest : PageRequest
    {
        // 1- Get all    2- GetActive    3- GetFinished
        public int Filter { get; set; } = 1;
        public int CustomerId { get; set; } = 0;
        public override string ToString()
        {
            return $"Filter={Filter}&Page={Page}&ItemsPerPage={ItemsPerPage}&CustomerId={CustomerId}";
        }
    }
}
