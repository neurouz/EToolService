using EToolService.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EToolService.WebAPI.Services.Interfaces
{
    public interface IReportService
    {
        List<int> GetYears();
        int GetSoldProducts(ReportSearchRequest request);
        EToolService.Model.Models.Product GetMostSellingProduct(ReportSearchRequest request);
        int GetServiceCount(ReportSearchRequest request);
        decimal GetServiceEarnings(ReportSearchRequest request);
        decimal GetProductionEarnings(ReportSearchRequest request);
        Model.Models.Customer GetTopCustomer(ReportSearchRequest request);
        List<EToolService.Model.Models.Services> GetServices(ReportSearchRequest request);
    }
}
