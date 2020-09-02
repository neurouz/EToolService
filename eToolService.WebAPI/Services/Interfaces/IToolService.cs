using EToolService.Model.Requests;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EToolService.WebAPI.Services.Interfaces
{
    public interface IToolService
    {
        List<EToolService.Model.Models.Services> Get(ToolServiceSearchRequest request);
        int GetPendingServices();
        EToolService.Model.Models.Services SetViewed(int id);
        EToolService.Model.Models.Services Delete(int id);
        EToolService.Model.Models.Services GetService(int id);
        bool IsResponsed(int id);
        EToolService.Model.Models.ServiceResponse SetResponse(ServiceResponseInsertRequest request);
        Task<EToolService.Model.Models.Services> Insert(ToolServiceInsertRequest request);
    }
}
