using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EToolService.Mobile.Helpers;
using EToolService.Model.Models;

namespace EToolService.Mobile.Services
{
    public class OrderService
    {
        private readonly APIService _service = new APIService("Order");
        public static Cart<Product> Cart { get; set; } = new Cart<Product>();

        public static void AddProduct(Product product, int quantity)
        {
            for (int i = 0; i < quantity; i++)
                Cart.Add(product);
        }

        public static void RemoveProduct(Product product) => Cart.Remove(product);
    }
}
