using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EToolService.Model.Requests;
using EToolService.WebAPI.Exceptions;
using EToolService.WebAPI.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EToolService.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("etoolservice-policy")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        private readonly IAccountService _accountService;
        public CustomerController(ICustomerService customerService, IAccountService accountService)
        {
            _customerService = customerService;
            _accountService = accountService;
        }

        [Authorize]
        [HttpGet]
        public List<Model.Models.Customer> GetAll([FromQuery]CustomerSearchRequest request, bool showAll)
        {
            return _customerService.GetAll(request, showAll);
        }

        [Authorize]
        [HttpGet("{id}")]
        public async Task<Model.Models.Customer> GetById(int? id)
        {
            return await _customerService.GetById(id);
        }

        [HttpPost]
        public async Task<Model.Models.Customer> Insert([FromBody] CustomerInsertRequest request)
        {
            if (!ModelState.IsValid)
            {
                throw new UserException("Morate popuniti sva polja ispravno");
            }
            return await _customerService.Insert(request);
        }

        [Authorize]
        [HttpPut("{id}")]
        public async Task<Model.Models.Customer> Update(int? id, [FromBody]CustomerUpdateRequest request)
        {
            return await _customerService.Update(id, request);
        }

        [AllowAnonymous]
        [HttpGet("GetByAccountId/{accountId}")]
        public async Task<Model.Models.Customer> GetByAccountId(int? accountId)
        {
            return await _customerService.GetByAccountId(accountId);
        }

        [Authorize]
        [HttpDelete("{id}")]
        public async Task<Model.Models.Customer> Delete(int? id)
        {
            return await _customerService.Delete(id);
        }

    }
}