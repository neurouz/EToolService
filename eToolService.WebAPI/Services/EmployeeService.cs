using AutoMapper;
using EToolService.Model.Requests;
using EToolService.WebAPI.Database;
using EToolService.WebAPI.Exceptions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using EToolService.WebAPI.Services.Interfaces;

namespace EToolService.WebAPI.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly Context _context;
        private readonly IMapper _mapper;
        public EmployeeService(Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Model.Models.Employee AddMachine(int? employeeId, int? machineId, string level)
        {
            if (employeeId == null) throw new UserException("ID uposlenika ne može biti prazno polje");
            if (machineId == null) throw new UserException("ID mašine ne može biti prazno polje");

            var employee = _context.Employee.Find(employeeId);
            if (employee == null) throw new UserException("Uposlenik nije pronađen");

            var machine = _context.Machine.Find(machineId);
            if (machine == null) throw new UserException("Mašina nije pronađena");

            _context.EmployeeMachine.Add(new EmployeeMachine
            {
                EmployeeId = (int)employeeId,
                MachineId = (int)machineId,
                Level = String.IsNullOrEmpty(level) ? null : level 
            });

            _context.SaveChanges();

            var entity = _context.Employee.Find(employeeId);
            var result = _mapper.Map<Model.Models.Employee>(entity);
            
            GetEmployeeMachines(result);
            GetEmployeeRequests(result);

            return result;
        }
        public Model.Models.Employee RemoveMachine(int? employeeId, int? machineId)
        {
            if (employeeId == null) throw new UserException("ID uposlenika ne može biti prazno polje");
            if (machineId == null) throw new UserException("ID mašine ne može biti prazno polje");

            var entity = _context.EmployeeMachine
                .Where(x => x.EmployeeId == employeeId && x.MachineId == machineId)
                .SingleOrDefault();

            if (entity == null)
                throw new UserException("Uposlenik nije zadužio tu mašinu");

            _context.EmployeeMachine.Attach(entity);
            _context.EmployeeMachine.Remove(entity);
            _context.SaveChanges();

            var employee = _context.Employee.Find(employeeId);
            var result = _mapper.Map<Model.Models.Employee>(employee);

            GetEmployeeMachines(result);
            GetEmployeeRequests(result);

            return result;
        }

        public Model.Models.Employee Delete(int? id)
        {
            if (id == null)
                throw new UserException("ID ne može biti prazno polje");

            var entity = _context.Employee.Find(id);

            if (entity == null)
                throw new UserException("Uposlenik nije pronađen");

            entity.Active = false;
            _context.SaveChanges();

            return _mapper.Map<Model.Models.Employee>(entity);

        }
        public List<Model.Models.Employee> GetAll(EmployeeSearchRequest request, bool showAll)
        {
            // If showAll is true, it will fetch all rows from database
            // Otherwise, it will return only active employees
            var query = _context.Employee
                .Where(x => showAll == true ? 
                    x.Active == true || x.Active == false : x.Active == true)
                .AsQueryable();

            if(request.ItemsPerPage > 0)
                if ((int) (query.Count() / request.ItemsPerPage + 0.5) > request.ItemsPerPage)
                    return null;

            if (!String.IsNullOrEmpty(request.FirstName))
                query = query.Where(x => x.FirstName.StartsWith(request.FirstName));
            if (!String.IsNullOrEmpty(request.LastName))
                query = query.Where(x => x.LastName.StartsWith(request.LastName));

            if(request.Page != -1)
                query = query
                    .Skip((request.Page - 1) * request.ItemsPerPage)
                    .Take(request.ItemsPerPage);

            var list = query.ToList();
            var result = _mapper.Map<List<Model.Models.Employee>>(list);

            foreach(var employee in result)
                GetEmployeeMachines(employee);
            
            foreach(var employee in result)
                GetEmployeeRequests(employee);            

            return result;
        }
        public Model.Models.Employee GetById(int? id)
        {
            if (id == null)
                throw new UserException("ID ne može biti prazno polje");

            var entity = _context.Employee.Find(id);

            if (entity == null)
                throw new UserException("Uposlenik nije pronađen");

            var result = _mapper.Map<Model.Models.Employee>(entity);

            GetEmployeeRequests(result);
            GetEmployeeMachines(result);
            
            return result;
        }
        public Model.Models.Employee Insert(EmployeeInsertRequest request)
        {
            if (request == null)
                throw new UserException("Podaci su obavezni");

            var entity = _mapper.Map<Database.Employee>(request);
            entity.Active = true;

            if (request.ContractSigned == null)
                entity.ContractSigned = DateTime.Now;

            _context.Employee.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Models.Employee>(entity);
        }
        public Model.Models.Employee Update(int? id, EmployeeUpdateRequest request)
        {
            if(id == null)
                throw new UserException("ID ne može biti prazno polje");

            var entity = _context.Employee.Find(id);

            if (entity == null)
                throw new UserException("Korisnik nije pronađen");

            UpdateEmployee(entity, request);

            var result = _mapper.Map<Model.Models.Employee>(entity);

            GetEmployeeRequests(result);
            GetEmployeeMachines(result);

            return result;

        }


        private void GetEmployeeMachines(Model.Models.Employee employee)
        {
            var employeeMachine = _context.EmployeeMachine
                .Include(x => x.Machine)
                .Include(x => x.Employee).ToList();

            foreach (var employee_machine in employeeMachine)
            {
                if (employee_machine.EmployeeId == employee.Id)
                {
                    var machine = _context.Machine
                        .Where(x => x.Id == employee_machine.MachineId)
                        .FirstOrDefault();
                    employee.Machines.Add(_mapper.Map<Model.Models.Machine>(machine));
                }
            }
        }
        private void GetEmployeeRequests(Model.Models.Employee employee)
        {
            var employeeRequests = _context.EmployeeRequest
                .Include(x => x.Administrator)
                .Include(x => x.Employee).ToList();

            foreach (var request in employeeRequests)
            {
                if (request.EmployeeId == employee.Id)
                    employee.Requests.Add(_mapper.Map<Model.Models.Request>(request));
            }
        }
        private void UpdateEmployee(Database.Employee employee, Model.Requests.EmployeeUpdateRequest request)
        {
            if (request.Active != null) employee.Active = request.Active;
            if (request.ContractSigned != null) employee.ContractSigned = (DateTime)request.ContractSigned;
            if (request.FirstName != null) employee.FirstName = request.FirstName;
            if (request.LastName != null) employee.LastName = request.LastName;
            if (request.Position != null) employee.Position = request.Position;
            if (request.Salary != null) employee.Salary = (decimal)request.Salary;
            _context.SaveChanges();
        }

        public List<Model.Models.Machine> GetMachines()
        {
            var machines = _context.Machine.ToList();
            return _mapper.Map<List<Model.Models.Machine>>(machines);
        }
    }
}
