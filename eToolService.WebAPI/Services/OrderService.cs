using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EToolService.WebAPI.Database;
using EToolService.WebAPI.Services.Interfaces;
using EToolService.Model.Requests;
using EToolService.WebAPI.Exceptions;

namespace EToolService.WebAPI.Services
{
    public class OrderService : IOrderService
    {
        private readonly Context _context;
        private readonly IMapper _mapper;

        public OrderService(Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Models.Order> Get(OrderSearchRequest request)
        {
            if (request.Filter < 1 || request.Filter > 3)
                throw new UserException("Filter za narudžbe nije validan");

            var query = _context.Order.OrderByDescending(x => x.OrderDate).AsQueryable();

            if (request.CustomerId != 0)
            {
                query = query.Where(x => x.CustomerId == request.CustomerId);
            }

            // Aktivni
            if (request.Filter == 2) query = query.Where(x => (bool)x.Active);
            // Neaktivni
            if (request.Filter == 3) query = query.Where(x => (bool)!x.Active); 

            // Ako koristimo pagination
            if (request.Page != -1)
            {
                query = query
                    .Skip((request.Page - 1) * request.ItemsPerPage)
                    .Take(request.ItemsPerPage);
            }

            var data = query.ToList();

            var orders = _mapper.Map<List<Model.Models.Order>>(data);

            foreach (var order in orders)
            {
                order.Products = new List<KeyValuePair<int, Model.Models.Product>>();
                order.Products = GetOrderProducts(order.Id);
                order.CustomerName = _context.Customer.Find(order.CustomerId).CompanyName;
            }

            return orders;
        }

        public Model.Models.Order Insert(OrderInsertRequest request)
        {
            var order = _context.Order.Add(new Order()
            {
                Active = true,
                ShippingAddress = request.ShippingAddress,
                CustomerId = request.CustomerId,
                ContactNumber = request.ContactNumber,
                OrderDate = DateTime.Now
            });

            _context.SaveChanges();

            for (int i = 0; i < request.Products.Count; i++)
            {
                _context.ProductOrder.Add(new ProductOrder()
                {
                    ProductId = request.Products[i],
                    OrderId = order.Entity.Id,
                    Quantity = request.Quantities[i]
                });
            }

            _context.SaveChanges();

            var result = _mapper.Map<Model.Models.Order>(order.Entity);

            result.Products = new List<KeyValuePair<int, Model.Models.Product>>();
            result.Products = GetOrderProducts(result.Id);
            result.CustomerName = _context.Customer.Find(result.CustomerId).CompanyName;

            return result;
        }

        public Model.Models.Order SetInactive(int id)
        {
            var order = _context.Order.Find(id);
            if (order == null)
                throw new UserException("Order ID nije validan");

            order.Active = false;
            _context.SaveChanges();

            return _mapper.Map<Model.Models.Order>(order);
        }

        private List<KeyValuePair<int, Model.Models.Product>> GetOrderProducts(int orderID)
        {
            var productOrders = _context.ProductOrder.Where(x => x.OrderId == orderID).ToList();
            List<KeyValuePair<int, Database.Product>> products = 
                new List<KeyValuePair<int, Database.Product>>();

            foreach (var po in productOrders)
            {
                products.Add(new KeyValuePair<int, Database.Product>(po.Quantity, _context.Product.Find(po.ProductId)));
            }

            return _mapper.Map<List<KeyValuePair<int, Model.Models.Product>>>(products);
        }

    }
}
