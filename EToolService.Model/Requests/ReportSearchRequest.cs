using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EToolService.Model.Requests
{
    public class ReportSearchRequest
    {
        public int year { get; set; }
        public int month { get; set; }
        public override string ToString()
        {
            return $"year={year}&month={month}";
        }
    }
}
