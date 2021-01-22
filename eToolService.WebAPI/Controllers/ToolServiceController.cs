using System.Collections.Generic;
using System.Threading.Tasks;
using EToolService.Model.Requests;
using EToolService.WebAPI.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace EToolService.WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("etoolservice-policy")]
    public class ToolServiceController : ControllerBase
    {
        private readonly IToolService _service;

        public ToolServiceController(IToolService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<EToolService.Model.Models.Services> Get([FromQuery] ToolServiceSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpGet("GetPendingServices")]
        public int GetPendingServices()
        {
            return _service.GetPendingServices();
        }

        [HttpPatch("{id}")]
        public EToolService.Model.Models.Services SetViewed(int id)
        {
            return _service.SetViewed(id);
        }

        [HttpDelete("{id}")]
        public EToolService.Model.Models.Services Delete(int id)
        {
            return _service.Delete(id);
        }

        [HttpGet("GetService/{id}")]
        public EToolService.Model.Models.Services GetService(int id)
        {
            return _service.GetService(id);
        }

        [HttpGet("IsResponsed/{id}")]
        public bool IsResponsed(int id)
        {
            return _service.IsResponsed(id);
        }

        [HttpPost]
        public EToolService.Model.Models.ServiceResponse Respond(ServiceResponseInsertRequest request)
        {
            return _service.SetResponse(request);
        }

        [HttpPost("InsertService")]
        public async Task<EToolService.Model.Models.Services> Insert([FromBody] ToolServiceInsertRequest request)
        {
            return await _service.Insert(request);
        }
    }
}