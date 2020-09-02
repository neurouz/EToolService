using AutoMapper;
using EToolService.WebAPI.Database;
using EToolService.WebAPI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using TwinFinder.Matching.StringFuzzyCompare.Base;
using TwinFinder.Matching.StringFuzzyCompare.Common;

namespace EToolService.WebAPI.Services
{
    public class RecommenderService
    {
        private readonly Context _context;
        private readonly IMapper _mapper;
        private readonly int _customerId;
        private const float ALLOWED_PERCENTAGE = 65f;

        public RecommenderService(IMapper mapper, Context context)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<Model.Models.Product>> Recommend(int clientId)
        {
            // Svi proizvodi
            var products = _context.Product.ToList();

            // top 4 servisa za odredjenog klijenta
            var services = _context.Service
                .Where(x => x.CustomerId == clientId)
                .GroupBy(x => x.ToolName)
                .Select(x => new { ToolName = x.Key, Count = x.Sum(a => a.Quantity) })
                .OrderByDescending(x => x.Count)
                .Take(4);

            List<Model.Models.Product> recommendedProducts = new List<Model.Models.Product>();

            foreach (var service in services)
            {
                foreach (var product in products)
                {
                    StringFuzzyComparer smithwaterman = new SmithWaterman();
                    var similarity = smithwaterman.Compare(service.ToolName.ToLower(), product.ProductName.ToLower()) * 100;
                    if(similarity >= ALLOWED_PERCENTAGE)
                    {
                        var mappedProduct = _mapper.Map<Model.Models.Product>(product);
                        if (!recommendedProducts.Contains(mappedProduct))
                        {
                            recommendedProducts.Add(mappedProduct);
                        }
                    }
                }
            }

            return recommendedProducts;
        }
    }
}