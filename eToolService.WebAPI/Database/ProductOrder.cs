using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EToolService.WebAPI.Database
{
    public class ProductOrder
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public int Quantity { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
