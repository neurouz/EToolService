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
    public class MaterialController : ControllerBase
    {
        private readonly IMaterialService _service;
        public MaterialController(IMaterialService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<EToolService.Model.Models.Material> Get([FromQuery]MaterialSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpPost]
        public EToolService.Model.Models.Material Post([FromBody]MaterialInsertRequest request)
        {
            return _service.Post(request);
        }

        [HttpPatch("{id}")]
        public EToolService.Model.Models.Material SetInactive(int? id)
        {
            return _service.Patch(id);
        }
    }
}