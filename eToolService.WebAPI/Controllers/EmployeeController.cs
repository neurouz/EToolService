using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EToolService.Model.Models;
using EToolService.Model.Requests;
using EToolService.WebAPI.Exceptions;
using EToolService.WebAPI.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EToolService.WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService service)
        {
            _employeeService = service;
        }

        [HttpGet]
        public List<Model.Models.Employee> GetAll([FromQuery]EmployeeSearchRequest request, bool showAll)
        {
            return _employeeService.GetAll(request, showAll);
        }

        [HttpGet("{id}")]
        public Model.Models.Employee GetById(int? id)
        {
            return _employeeService.GetById(id);
        }

        [HttpPost]
        public Employee Insert([FromBody]EmployeeInsertRequest request)
        {
            if (!ModelState.IsValid)
            {
                throw new UserException("Morate popuniti sva polja");
            }
            return _employeeService.Insert(request);
        }

        [HttpPut("{id}")]
        public Model.Models.Employee Update(int? id, [FromBody] EmployeeUpdateRequest request)
        {
            return _employeeService.Update(id, request);
        }

        [HttpDelete("{id}")]
        public Model.Models.Employee Delete(int? id)
        {
            return _employeeService.Delete(id);
        }

        [HttpPatch("{employeeId}")]
        public Model.Models.Employee AddMachine(int? employeeId, MachineAssignRequest request, string level)
        {
            return _employeeService.AddMachine(employeeId, request.machineId, level);
        }

        [HttpDelete("{employeeId}, {machineId}")]
        public Model.Models.Employee RemoveMachine(int? employeeId, int? machineId)
        {
            return _employeeService.RemoveMachine(employeeId, machineId);
        }
    }
}