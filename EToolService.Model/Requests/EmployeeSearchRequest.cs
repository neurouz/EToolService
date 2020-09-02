using System;
using System.Collections.Generic;
using System.Text;
using EToolService.Model.Requests;

namespace EToolService.Model.Requests
{
    public class EmployeeSearchRequest : PageRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public override string ToString()
        {
            string query = "";
            if(!String.IsNullOrEmpty(FirstName))
                query += $"?FirstName={FirstName}";
            
            if (!String.IsNullOrEmpty(LastName))
                query += $"&LastName={LastName}";

            if (Page > 0)
                query += $"&Page={Page}&ItemsPerPage={ItemsPerPage}";

            return query;
        }
    }
}
