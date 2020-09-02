using System;
using System.Collections.Generic;
using EToolService.Model.Requests;
using EToolService.WebAPI.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EToolService.WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet]
        public List<Model.Models.Account> GetAll()
        {
            return _accountService.GetAll();
        }

        [HttpGet("id")]
        public Model.Models.Account GetById(int id)
        {
            return _accountService.Get(id);
        }

        [HttpPost]
        public Model.Models.Account Authenticate(AuthenticateRequest request)
        {
            return _accountService.Authenticate(request);
        }

        [HttpPost("Admin")]
        public Model.Models.Account AuthenticateAdmin(AuthenticateRequest request)
        {
            return _accountService.AuthenticateAdmin(request);
        }
    }
}