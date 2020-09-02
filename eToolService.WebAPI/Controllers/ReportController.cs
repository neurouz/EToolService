using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EToolService.Model.Requests;
using EToolService.WebAPI.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EToolService.WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly IReportService _service;
        public ReportController(IReportService service)
        {
            _service = service;
        }

        [HttpGet("Years")]
        public List<int> GetYears()
        {
            return _service.GetYears();
        }

        [HttpGet("ProductCount")]
        public int GetSoldProducts([FromQuery]ReportSearchRequest request)
        {
            return _service.GetSoldProducts(request);
        }

        [HttpGet("MostSelling")]
        public EToolService.Model.Models.Product MostSellingProduct([FromQuery] ReportSearchRequest request)
        {
            return _service.GetMostSellingProduct(request);
        }

        [HttpGet("ServiceNumber")]
        public int GetServiceCount([FromQuery] ReportSearchRequest request)
        {
            return _service.GetServiceCount(request);
        }

        [HttpGet("GetServices")]
        public List<EToolService.Model.Models.Services> GetServices([FromQuery] ReportSearchRequest request)
        {
            return _service.GetServices(request);
        }

        [HttpGet("ServiceEarnings")]
        public decimal GetServiceEarnings([FromQuery] ReportSearchRequest request)
        {
            return _service.GetServiceEarnings(request);
        }

        [HttpGet("ProductionEarnings")]
        public decimal GetProductionEarnings([FromQuery] ReportSearchRequest request)
        {
            return _service.GetProductionEarnings(request);
        }

        [HttpGet("TopCustomer")]
        public Model.Models.Customer GetTopCustomer([FromQuery] ReportSearchRequest request)
        {
            return _service.GetTopCustomer(request);
        }
    }
}