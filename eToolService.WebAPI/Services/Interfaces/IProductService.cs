using EToolService.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EToolService.WebAPI.Services.Interfaces
{
    public interface IProductService
    {
        Task<List<Model.Models.Product>> Get(ProductSearchRequest request);
        Task<Model.Models.Product> Get(int id);
        Task<List<Model.Models.Product>> Recommend(int clientId);
        Task<Model.Models.Product> Update(int id, ProductUpdateRequest request);
    }
}
