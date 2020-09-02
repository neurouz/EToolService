using System;
using System.Collections.Generic;

namespace EToolService.WebAPI.Database
{
    public class ServiceResponse
    {
        public int Id { get; set; }
        public int AdministratorId { get; set; }
        public int ServiceId { get; set; }
        public decimal Price { get; set; }
        public DateTime? FinishDate { get; set; }
        public bool Approved { get; set; }
        public string Explanation { get; set; }

        public virtual Administrator Administrator { get; set; }
        public virtual Service Service { get; set; }
    }
}
