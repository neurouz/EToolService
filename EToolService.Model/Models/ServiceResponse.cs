using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EToolService.Model.Models
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
    }
}
