using System;
using System.Collections.Generic;
using System.Text;

namespace EToolService.Model.Requests
{
    public class RequestInsertRequest
    {
        public string Description { get; set; }
        public string Purpose { get; set; }
        public int EmployeeId { get; set; }
    }
}
