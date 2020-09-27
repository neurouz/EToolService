using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EToolService.Model.Requests;
using EToolService.WebAPI.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EToolService.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _service;
        public ProductController(IProductService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<List<Model.Models.Product>> Get([FromQuery] ProductSearchRequest request)
        {
            return await _service.Get(request);
        }

        [HttpGet("Recommend/{clientId}")]
        public async Task<List<Model.Models.Product>> Recommend(int clientId)
        {
            return await _service.Recommend(clientId);
        }

        [HttpGet("{id}")]
        public async Task<Model.Models.Product> Get(int id)
        {
            return await _service.Get(id);
        }

        [HttpPatch("{id}")]
        public async Task<Model.Models.Product> Update(int id, [FromBody] ProductUpdateRequest request)
        {
            return await _service.Update(id, request);
        }

        [HttpPatch("SetInactive/{id}")]
        public async Task<Model.Models.Product> SetInactive(int id)
        {
            return await _service.SetInactive(id);
        }
    }
}
