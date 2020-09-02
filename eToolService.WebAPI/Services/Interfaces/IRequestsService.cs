using EToolService.Model.Enumerations;
using EToolService.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EToolService.WebAPI.Services.Interfaces
{
    public interface IRequestsService
    {
        List<Model.Models.Request> Get(RequestSearchRequest request, bool showAll);
        Model.Models.Request GetById(int? id);
        Model.Models.Request SetPhase(int id, RequestPhases phase);
        Model.Models.Request Insert(RequestInsertRequest request);
    }
}
