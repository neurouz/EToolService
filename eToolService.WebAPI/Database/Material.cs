using System;
using System.Collections.Generic;

namespace EToolService.WebAPI.Database
{
    public class Material
    {
        public int Id { get; set; }
        public decimal? Diameter { get; set; }
        public decimal? Length { get; set; }
        public decimal? Width { get; set; }
        public decimal? Thickness { get; set; }
        public string Quality { get; set; }
        public int Quantity { get; set; }
        public int Hardness { get; set; }
        public int AdministratorId { get; set; }
        public int MaterialTypeId { get; set; }
        public bool Available { get; set; }

        public virtual Administrator Administrator { get; set; }
        public virtual MaterialType MaterialType { get; set; }
    }
}
