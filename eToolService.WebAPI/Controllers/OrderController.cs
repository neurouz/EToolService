using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EToolService.Model.Requests;
using EToolService.WebAPI.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EToolService.WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("etoolservice-policy")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _service;
        public OrderController(IOrderService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<EToolService.Model.Models.Order> Get([FromQuery] OrderSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpPatch("{id}")]
        public EToolService.Model.Models.Order SetInactive(int id)
        {
            return _service.SetInactive(id);
        }

        [HttpPost]
        public EToolService.Model.Models.Order Insert([FromBody] OrderInsertRequest request)
        {
            return _service.Insert(request);
        }

    }
}