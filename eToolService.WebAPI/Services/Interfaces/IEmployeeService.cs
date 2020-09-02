using EToolService.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EToolService.WebAPI.Services.Interfaces
{
    public interface IEmployeeService
    {
        List<Model.Models.Employee> GetAll(EmployeeSearchRequest request, bool showAll);
        Model.Models.Employee Insert(EmployeeInsertRequest request);
        Model.Models.Employee Update(int? id, EmployeeUpdateRequest request);
        Model.Models.Employee Delete(int? id);
        Model.Models.Employee GetById(int? id);
        Model.Models.Employee AddMachine(int? employeeId, int? machineId, string level);
        Model.Models.Employee RemoveMachine(int? employeeId, int? machineId);
        List<Model.Models.Machine> GetMachines();
    }
}
