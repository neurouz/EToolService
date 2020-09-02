using AutoMapper;
using EToolService.WebAPI.Database;
using EToolService.WebAPI.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using EToolService.WebAPI.Services.Interfaces;
using EToolService.Model.Requests;
using EToolService.Model.Models;
using EToolService.Model.Enumerations;

namespace EToolService.WebAPI.Services
{
    public class RequestsService : IRequestsService
    {
        private readonly Context _context;
        private readonly IMapper _mapper;

        public RequestsService(Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Models.Request> Get(RequestSearchRequest request, bool showAll)
        {
            var requests = _context.EmployeeRequest.AsQueryable();

            if ((int)(requests.Count() / request.ItemsPerPage + 0.5) > request.ItemsPerPage)
                return null;

            //if (!showAll)
            //    requests = requests.Where(x => x.Phase != 3);

            if (request.EmployeeId != null)
                requests = requests.Where(x => x.EmployeeId == request.EmployeeId);

            if (request.Phase != null)
                requests = requests.Where(x => x.Phase == request.Phase);  
            
            requests = requests
                .Skip((request.Page - 1) * request.ItemsPerPage)
                .Take(request.ItemsPerPage);

            var list = requests.ToList();

            return _mapper.Map<List<Model.Models.Request>>(list);
        }

        public Model.Models.Request GetById(int? id)
        {
            if (id == null)
                throw new UserException("ID ne može biti prazno polje");

            var entity = _context.EmployeeRequest.Find(id);

            if (entity == null)
                throw new UserException("Zahtjev ne postoji u bazi");

            return _mapper.Map<Model.Models.Request>(entity);        
        }

        public Request Insert(RequestInsertRequest request)
        {
            var id = request.EmployeeId;
            var employee = _context.Employee.Find(id);

            if (employee == null)
                throw new UserException("Uposlenik ID " + id + ": nije pronađen");

            if (!(bool)employee.Active)
                throw new UserException("Uposlenik '" + employee.FirstName + " " + employee.LastName + "' više nije aktivan");

            EmployeeRequest entity = new EmployeeRequest
            {
                Description = request.Description,
                DateCreated = DateTime.Now,
                AdministratorId = 1,
                EmployeeId = request.EmployeeId,
                Phase = (int) RequestPhases.Watching,
                Purpose = request.Purpose
            };

            _context.EmployeeRequest.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Request>(entity);
        }

        public Request SetPhase(int id, RequestPhases phase)
        {
            var entity = _context.EmployeeRequest.Find(id);

            if (entity == null)
                throw new UserException("Zahtjev ne može biti odobren jer ne postoji u bazi");

            entity.Phase = (int)phase;
            _context.SaveChanges();

            return _mapper.Map<Request>(entity);
        }

    }
}
