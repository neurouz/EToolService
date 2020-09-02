using EToolService.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EToolService.Model.Models;

namespace EToolService.WebAPI.Services.Interfaces
{
    public interface IMaterialService
    {
        public List<Material> Get(MaterialSearchRequest request);
        public Material Post(MaterialInsertRequest request);
        public EToolService.Model.Models.Material Patch(int? id);
    }
}
