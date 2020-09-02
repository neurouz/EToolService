using System;
using System.Collections.Generic;
using System.Text;

namespace EToolService.Model.Requests
{
    public class CustomerSearchRequest
    {
        public string CompanyName { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            string query = "";

            if (!String.IsNullOrEmpty(CompanyName))
                query += $"CompanyName={CompanyName}";
            if (!String.IsNullOrEmpty(Address))
                query += $"Address={Address}";

            return query;
        }
    }
}
