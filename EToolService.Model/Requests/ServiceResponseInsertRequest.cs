using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EToolService.Model.Requests
{
    public class ServiceResponseInsertRequest
    {
        public int ServiceId { get; set; }
        public decimal Price { get; set; }
        public string FinishDate { get; set; }
        public bool Approved { get; set; }
        public string Explanation { get; set; }
    }
}
