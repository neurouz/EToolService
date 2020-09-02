using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EToolService.Model.Requests
{
    public class MaterialInsertRequest
    {
        public decimal? Diameter { get; set; }
        public decimal? Length { get; set; }
        public decimal? Width { get; set; }
        public decimal? Thickness { get; set; }
        public string Quality { get; set; }
        public int Quantity { get; set; }
        public int Hardness { get; set; }
        public int MaterialTypeId { get; set; }
    }
}
