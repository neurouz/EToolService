using System;
using System.Collections.Generic;

namespace EToolService.WebAPI.Database
{
    public class MaterialType
    {
        public MaterialType()
        {
            Material = new HashSet<Material>();
        }

        public int Id { get; set; }
        public string TypeName { get; set; }
        public string Label { get; set; }

        public virtual ICollection<Material> Material { get; set; }
    }
}
