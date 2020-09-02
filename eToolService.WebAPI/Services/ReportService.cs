using AutoMapper;
using EToolService.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EToolService.WebAPI.Services.Interfaces;
using EToolService.Model.Requests;
using Microsoft.VisualBasic.CompilerServices;

namespace EToolService.WebAPI.Services
{
    public class ReportService : IReportService
    {
        private readonly Context _context;
        private readonly IMapper _mapper;
        public ReportService(Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public EToolService.Model.Models.Product GetMostSellingProduct(ReportSearchRequest request)
        {
            // QUERY:

            // SELECT* FROM Product WHERE ID = (
            // SELECT ProductID FROM(
            // SELECT TOP 1 PO.ProductID AS ProductID, SUM(PO.Quantity) AS Quantity, COUNT(PO.ProductID) AS[Count]
            // FROM ProductOrder AS PO
            // INNER JOIN[Order] AS O ON O.ID = PO.OrderID
            // WHERE YEAR(O.OrderDate) = 2020 AND MONTH(O.OrderDate) = 1
            // GROUP BY ProductID
            // ORDER BY Quantity DESC, [Count] DESC) AS MostSelling)

            StringBuilder query = new StringBuilder();
            query.AppendLine(@"SELECT * FROM Product WHERE ID = (");
            query.AppendLine(@"SELECT ProductID FROM(");
            query.AppendLine(@"SELECT TOP 1 PO.ProductID AS ProductID, SUM(PO.Quantity) AS Quantity, COUNT(PO.ProductID) AS [Count]");
            query.AppendLine(@"FROM ProductOrder AS PO");
            query.AppendLine(@"INNER JOIN [Order] AS O ON O.ID = PO.OrderID");
            query.AppendLine(@"WHERE YEAR(O.OrderDate) = " + request.year.ToString() +" AND MONTH(O.OrderDate) = " + request.month.ToString());
            query.AppendLine(@"GROUP BY ProductID");
            query.AppendLine(@"ORDER BY Quantity DESC, [Count] DESC) AS MostSelling)");

            var product = _context.Product.FromSqlRaw(query.ToString()).FirstOrDefault();
            return _mapper.Map<EToolService.Model.Models.Product>(product);
        }

        public decimal GetProductionEarnings(ReportSearchRequest request)
        {
            // SELECT SUM(P.Price) FROM Product AS P
            // INNER JOIN ProductOrder AS PO ON P.ID = PO.ProductID
            // INNER JOIN[Order] AS O ON O.ID = PO.OrderID
            // WHERE YEAR(O.OrderDate) = 2020 AND MONTH(O.OrderDate) = 1

            if (request != null)
            {
                var result = _context.Product
                    .Join(_context.ProductOrder,
                        p => p.Id,
                        po => po.ProductId,
                        (p, po) => new {Product = p, ProductOrder = po})
                    .Join(_context.Order,
                        entry => entry.ProductOrder.OrderId,
                        o => o.Id,
                        (entry, o) => new {Product = entry.Product, ProductOrder = entry.ProductOrder, Order = o})
                    .Where(x => x.Order.OrderDate.Year == request.year && x.Order.OrderDate.Month == request.month)
                    .Sum(x => (x.Product.Price * (decimal)(1 - x.Product.Discount)) * x.ProductOrder.Quantity);

                return result;
            }
            else
            {
                var result = _context.Product
                    .Join(_context.ProductOrder,
                        p => p.Id,
                        po => po.ProductId,
                        (p, po) => new { Product = p, ProductOrder = po })
                    .Join(_context.Order,
                        entry => entry.ProductOrder.OrderId,
                        o => o.Id,
                        (entry, o) => new { Product = entry.Product, ProductOrder = entry.ProductOrder, Order = o })
                    .Sum(x => (x.Product.Price * (decimal)(1 - x.Product.Discount)) * x.ProductOrder.Quantity);

                return result;
            }
            

        }

        public decimal GetServiceEarnings(ReportSearchRequest request)
        {

            // SELECT SUM(Price) AS Total FROM ServiceResponse AS SR
            // INNER JOIN[Service] AS S ON S.ID = SR.ServiceID
            // WHERE YEAR(S.DateCreated) = 2020 AND MONTH(S.DateCreated) = 1 AND SR.Approved = 1

            if (request != null)
            {
                var result = _context.ServiceResponse
                    .Join(_context.Service,
                        SR => SR.ServiceId,
                        S => S.Id,
                        (SR, S) => new { ServiceResponse = SR, Service = S })
                    .Where(i => i.Service.DateCreated.Year == request.year && i.Service.DateCreated.Month == request.month)
                    .Where(i => i.ServiceResponse.Approved)
                    .Sum(i => i.ServiceResponse.Price);

                return result;
            }
            else
            {
                var result = _context.ServiceResponse
                    .Join(_context.Service,
                        SR => SR.ServiceId,
                        S => S.Id,
                        (SR, S) => new { ServiceResponse = SR, Service = S })
                    .Where(i => i.ServiceResponse.Approved)
                    .Sum(i => i.ServiceResponse.Price);

                return result;
            }
        }

        public int GetServiceCount(ReportSearchRequest request)
        {
            if(request != null)
                return _context.ServiceResponse
                    .Join(_context.Service, SR => SR.ServiceId, S => S.Id, (SR, S) => new { ServiceResponse = SR, Service = S})
                    .Where(x => x.Service.DateCreated.Month == request.month && x.Service.DateCreated.Year == request.year)
                    .Where(x => (bool)x.ServiceResponse.Approved)
                    .ToList()
                    .Count();

            return _context.Service.ToList().Count();
        }

        public int GetSoldProducts(ReportSearchRequest request)
        {
            // QUERY:

            // SELECT SUM(Quantity)
            // FROM[Order] AS O
            // INNER JOIN ProductOrder AS PO ON O.ID = PO.OrderID
            // WHERE YEAR(O.OrderDate) = {request.year} AND MONTH(O.OrderDate) = {request.month}

            var result = _context.Order
              .Join(_context.ProductOrder,
                      t => t.Id,
                      a => a.OrderId,
                      (t, a) => new { Order = t, ProductOrder = a })
              .Where(i => i.Order.OrderDate.Year == request.year && i.Order.OrderDate.Month == request.month)
              .Sum(i => i.ProductOrder.Quantity);

            return result;
        }

        public Model.Models.Customer GetTopCustomer(ReportSearchRequest request)
        {
            StringBuilder query = new StringBuilder();
            query.AppendLine(@"SELECT * FROM Customer WHERE ID = (");
            query.AppendLine(@"SELECT CustomerID FROM(");
            query.AppendLine(@"SELECT TOP 1 CustomerID, Count(CustomerID) AS [Count]");
            query.AppendLine(@"FROM [Order]");
            if(request != null)
                query.AppendLine(@"WHERE YEAR(OrderDate) = " + request.year + " AND MONTH(OrderDate) = " + request.month);
            query.AppendLine(@"GROUP BY CustomerID");
            query.AppendLine(@"ORDER BY [Count] DESC) AS Customers)");

            var customer = _context.Customer.FromSqlRaw(query.ToString()).FirstOrDefault();
            return _mapper.Map<Model.Models.Customer>(customer);
        }

        public List<int> GetYears()
        {
            var orderYears = _context.Order.Select(x => x.OrderDate.Year).Distinct();
            var serviceYears = _context.Service.Select(x => x.DateCreated.Year).Distinct();

            List<int> years = new List<int>();
            years.AddRange(orderYears);
            years.AddRange(serviceYears);

            foreach (int order_year in orderYears)
            {
                foreach(int service_year in serviceYears)
                {
                    if (order_year == service_year)
                        years.Remove(order_year);
                }
            }

            return years.OrderBy(x => x).ToList();
        }

        public List<EToolService.Model.Models.Services> GetServices(ReportSearchRequest request)
        {
            var query = _context.Service
                .Include(x => x.Customer)
                .Join(_context.ServiceResponse, s => s.Id, sp => sp.ServiceId, 
                    (s, sp) => new { Service = s, ServiceResponse = sp })
                .AsQueryable();

            if(request != null)
            {
                query = query.Where(x => x.Service.DateCreated.Year == request.year &&
                    x.Service.DateCreated.Month == request.month)
                    .Where(x => x.ServiceResponse.Approved);
            }

            var data = query.ToList();

            List<EToolService.Model.Models.Services> services = 
                new List<EToolService.Model.Models.Services>();

            foreach(var obj in data)
            {
                services.Add(new EToolService.Model.Models.Services
                {
                    Approved = obj.ServiceResponse.Approved,
                    Attachment = obj.Service.Attachment,
                    CustomerId = obj.Service.CustomerId,
                    CustomerName = obj.Service.Customer.CompanyName,
                    DateCreated = obj.Service.DateCreated,
                    Id = obj.Service.Id,
                    Note = obj.Service.Note,
                    Price = obj.ServiceResponse.Price,
                    ServiceType = obj.Service.ServiceType,
                    ToolName = obj.Service.ToolName,
                    Urgent = obj.Service.Urgent
                });

            }

            return services;
        }
    }
}
