using EToolService.Model.Requests;
using EToolService.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EToolService.WebAPI.Services.Interfaces
{
    public interface ICustomerService
    {
        List<Model.Models.Customer> GetAll(CustomerSearchRequest request, bool showAll);
        Task<Model.Models.Customer> Insert(CustomerInsertRequest request);
        Task<Model.Models.Customer> GetById(int? id);
        Task<Model.Models.Customer> GetByAccountId(int? accountId);
        Task<Model.Models.Customer> Update(int? id, CustomerUpdateRequest request);
        Task<Model.Models.Customer> Delete(int? id);
    }
}
