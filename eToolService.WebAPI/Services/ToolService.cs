using AutoMapper;
using EToolService.Model.Requests;
using EToolService.WebAPI.Database;
using EToolService.WebAPI.Exceptions;
using EToolService.WebAPI.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EToolService.WebAPI.Services
{
    public class ToolService : IToolService
    {
        private readonly Context _context;
        private readonly IMapper _mapper;

        public ToolService(Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Model.Models.Services Delete(int id)
        {
            var entity = _context.Service.Find(id);

            if (entity == null)
                throw new UserException("Zapis ne postoji u bazi");

            var serviceResponse = _context.ServiceResponse
                .Where(x => x.ServiceId == entity.Id).FirstOrDefault();

            if (serviceResponse != null)
                _context.ServiceResponse.Remove(serviceResponse);

            _context.Service.Remove(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Models.Services>(entity);
        }

        public List<Model.Models.Services> Get(ToolServiceSearchRequest request)
        {
            var query = _context.Service
                .Include(x => x.Customer)
                .OrderByDescending(x => x.DateCreated).AsQueryable();

            if (request.CustomerId != 0)
            {
                query = query.Where(x => x.CustomerId == request.CustomerId);
            }

            if (request.Page != -1)
            {
                query = query
                    .Skip((request.Page - 1) * request.ItemsPerPage)
                    .Take(request.ItemsPerPage);
            }

            var data = query.ToList();

            var result = _mapper.Map<List<Model.Models.Services>>(data);

            foreach (var service in result)
            {
                var response = _context.ServiceResponse
                    .Where(x => x.ServiceId == service.Id)
                    .SingleOrDefault();

                if (response != null)
                {
                    service.FinishDate = response.FinishDate;
                    service.Price = response.Price;
                    service.Approved = response.Approved;
                    service.Explanation = response.Explanation;
                }
            }
            return result;
        }

        public int GetPendingServices()
        {
            return _context.Service.Where(x => (bool)!x.Viewed).Count();
        }

        public Model.Models.Services GetService(int id)
        {
            var service = _context.Service.Include(x => x.Customer)
                .Where(x => x.Id == id)
                .SingleOrDefault();
         
            if (service == null)
                throw new UserException("Servis nije pronadjen");

            Model.Models.Services result = new Model.Models.Services();

            result.Attachment = service.Attachment;
            result.CustomerName = service.Customer.CompanyName;
            result.Id = service.Id;
            result.Note = service.Note;
            result.ServiceType = service.ServiceType;
            result.ToolName = service.ToolName;
            result.Urgent = service.Urgent;
            result.Viewed = service.Viewed;
            result.DateCreated = service.DateCreated;
            result.Quantity = service.Quantity;
            result.Responsed = service.Responsed;

            var response = _context.ServiceResponse
                .Where(x => x.ServiceId == id)
                .SingleOrDefault();

            if(response != null)
            {
                result.FinishDate = response.FinishDate;
                result.Price = response.Price;
                result.Approved = response.Approved;
                result.Explanation = response.Explanation;
            }

            return result;
        }

        public async Task<Model.Models.Services> Insert(ToolServiceInsertRequest request)
        {
            var entity = new Service()
            {
                Quantity = request.Quantity,
                CustomerId = request.CustomerId,
                DateCreated = DateTime.Now,
                Note = request.Note,
                ServiceType = request.ServiceType,
                ToolName = request.ToolName,
                Urgent = request.Urgent,
                Viewed = false,
                Responsed = false,              
                Attachment = null
            };

            var service = _context.Service.Add(entity);
            _context.SaveChanges();

            if (request.Attachment != null)
            {
                var filename = $"attachment_{service.Entity.Id}";
                var extension = Path.GetExtension(request.FileName);
                var path = Path.Combine(Directory.GetCurrentDirectory(), "Data", "ServiceAttachments", $"{filename}{extension}");

                entity.Attachment = $"{filename}{extension}";

                await File.WriteAllBytesAsync(path, request.Attachment);
            }

            await _context.SaveChangesAsync();

            return _mapper.Map<Model.Models.Services>(entity);
        }

        public bool IsResponsed(int id)
        {
            Database.ServiceResponse entity = null;
            try
            {
                entity = _context.ServiceResponse.Where(x => x.ServiceId == id)
                    .First();
            }
            catch (Exception)
            {
                return false;
            }
            
            if (entity == null)
                return false;
            return true;
        }

        public Model.Models.ServiceResponse SetResponse(ServiceResponseInsertRequest request)
        {
            var entity = new Database.ServiceResponse()
            {
                AdministratorId = 1,
                Approved = request.Approved,
                Explanation = request.Explanation,
                FinishDate = DateTime.ParseExact(request.FinishDate, "yyyy MMMM dd", null),
                Price = request.Price,
                ServiceId = request.ServiceId
            };

            var service = _context.Service.Find(request.ServiceId);
            if(service != null)
            {
                service.Responsed = true;
            }

            var e = _context.ServiceResponse.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Models.ServiceResponse>(entity);
        }

        public Model.Models.Services SetViewed(int id)
        {
            var service = _context.Service.Find(id);

            if (service == null)
                throw new UserException("ID Servisa nije validan");

            service.Viewed = true;
            _context.SaveChanges();

            return _mapper.Map<Model.Models.Services>(service);
        }
    }
}
