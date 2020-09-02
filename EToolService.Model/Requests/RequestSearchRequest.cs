using EToolService.Model.Requests;
using System;
using System.Collections.Generic;
using System.Text;

namespace EToolService.Model.Requests
{
    public class RequestSearchRequest : PageRequest
    {
        public int? Phase { get; set; } = null;
        public int? EmployeeId { get; set; } = null;
        public override string ToString()
        {
            var query = "";

            if (Phase != null)
                query += $"Phase={Phase}";
            if (EmployeeId != null)
                query += $"EmployeeId={EmployeeId}";
            if (Page > 0)
                query += $"&Page={Page}&ItemsPerPage={ItemsPerPage}";

            return query;
        }
    }
}
