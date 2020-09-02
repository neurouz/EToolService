using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EToolService.WebAPI.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EToolService.WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class MachineController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public MachineController(IEmployeeService service)
        {
            _employeeService = service;
        }

        [HttpGet]
        public List<Model.Models.Machine> GetAll()
        {
            return _employeeService.GetMachines();
        }
    }
}