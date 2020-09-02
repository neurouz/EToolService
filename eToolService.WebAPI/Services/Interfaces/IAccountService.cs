using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EToolService.Model.Requests;

namespace EToolService.WebAPI.Services.Interfaces
{
    public interface IAccountService
    {
        List<Model.Models.Account> GetAll();
        Model.Models.Account Get(int id);
        Model.Models.Account Authenticate(AuthenticateRequest request);
        Model.Models.Account AuthenticateAdmin(AuthenticateRequest request);
    }
}
