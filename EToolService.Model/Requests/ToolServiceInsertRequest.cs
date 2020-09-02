using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EToolService.Model.Requests
{
    public class ToolServiceInsertRequest
    {
        public string ToolName { get; set; }
        public string ServiceType { get; set; }
        public string Note { get; set; }
        public bool Urgent { get; set; }
        public byte[] Attachment { get; set; } = null;
        public string FileName { get; set; }
        public int CustomerId { get; set; }
        public int Quantity { get; set; }
    }
}
