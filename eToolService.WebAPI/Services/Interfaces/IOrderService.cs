using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EToolService.Model.Requests;

namespace EToolService.WebAPI.Services.Interfaces
{
    public interface IOrderService
    {
        List<EToolService.Model.Models.Order> Get(OrderSearchRequest request);
        EToolService.Model.Models.Order SetInactive(int id);
        EToolService.Model.Models.Order Insert(OrderInsertRequest request);
    }
}
