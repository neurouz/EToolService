using EToolService.Model.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EToolService.Model.Models
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
        public int MaterialTypeId { get; set; }
        public bool Available { get; set; }
        public string GetDimensions()
        {
            if(MaterialTypeId == (int)MaterialTypes.BarMaterial)
                return $"D{Diameter} x {Length}mm";
            else
                return $"L{Length} x {Width} x {Thickness}mm";
        }
    }
}
