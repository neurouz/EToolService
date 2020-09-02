using System;
using System.Collections.Generic;

namespace EToolService.WebAPI.Database
{
    public class Service
    {
        public int Id { get; set; }
        public string ToolName { get; set; }
        public string ServiceType { get; set; }
        public string Note { get; set; }
        public bool Urgent { get; set; }
        public string Attachment { get; set; }
        public DateTime DateCreated { get; set; }
        public int CustomerId { get; set; }
        public bool? Viewed { get; set; }
        public int Quantity { get; set; }
        public bool? Responsed { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
