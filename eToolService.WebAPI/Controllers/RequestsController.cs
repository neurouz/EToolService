using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EToolService.Model.Enumerations;
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
    public class RequestsController : ControllerBase
    {
        private readonly IRequestsService _requestsService;
        public RequestsController(IRequestsService requestsService)
        {
            _requestsService = requestsService;
        }

        [HttpGet]
        public List<Model.Models.Request> Get([FromQuery]RequestSearchRequest request, bool showAll)
        {
            return _requestsService.Get(request, showAll);
        }

        [HttpGet("{id}")]
        public Model.Models.Request GetById(int? id)
        {
            return _requestsService.GetById(id);
        }

        [HttpPatch("{id}")]
        public Model.Models.Request SetPhase(int id, [FromBody]RequestPhases phase)
        {
            return _requestsService.SetPhase(id, phase);
        }

        [HttpPost]
        public Model.Models.Request Insert(RequestInsertRequest request)
        {
            return _requestsService.Insert(request);
        }
    }
}