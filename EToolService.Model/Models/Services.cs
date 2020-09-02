using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EToolService.Model.Models
{
    public class Services
    {
        public int Id { get; set; }
        public string ToolName { get; set; }
        public string ServiceType { get; set; }
        public string Note { get; set; }
        public bool Urgent { get; set; }
        public string Attachment { get; set; }
        public DateTime DateCreated { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public bool Approved { get; set; }
        public decimal Price { get; set; }
        public bool? Viewed { get; set; }
        public DateTime? FinishDate { get; set; }
        public string Explanation { get; set; }
        public int Quantity { get; set; }
        public bool? Responsed { get; set; }

    }
}
