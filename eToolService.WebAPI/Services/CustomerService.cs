using AutoMapper;
using EToolService.Model.Requests;
using EToolService.WebAPI.Database;
using EToolService.WebAPI.Exceptions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EToolService.WebAPI.Services.Interfaces;

namespace EToolService.WebAPI.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly Context _context;
        private readonly IMapper _mapper;
        public CustomerService(Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Models.Customer> GetAll(CustomerSearchRequest request, bool showAll)
        {
            // If showAll is true, it will fetch all rows from database
            // Otherwise, it will return only active customers
            var query = _context.Customer.Include(x => x.Account)
                .Include(x => x.Area)
                .Where(x => showAll == true ? x.Active == true || x.Active == false : x.Active == true)
                .AsQueryable();

            if (!String.IsNullOrEmpty(request.CompanyName))
            {
                query = query.Where(x => x.CompanyName.StartsWith(request.CompanyName));
            }
            if (!String.IsNullOrEmpty(request.Address))
            {
                query = query.Where(x => x.Address.StartsWith(request.Address));
            }

            var list = query.ToList();

            var obj = _mapper.Map<List<Model.Models.Customer>>(list);
            return obj;
        }
        public async Task<Model.Models.Customer> Insert(CustomerInsertRequest request)
        {
            if (request.Password != request.PasswordConfirm)
                throw new UserException("Lozinke moraju biti iste");

            var salt = AccountService.GenerateSalt();
            var hash = AccountService.GenerateHash(salt, request.Password);

            // Adding account for customer
            Database.Account customerAccount = new Database.Account()
            {
                DateCreated = DateTime.Now,
                Email = request.Email,
                PasswordSalt = salt,
                PasswordHash = hash,
                PhoneNumber = request.PhoneNumber,
                Username = request.Username
            };

            await _context.Account.AddAsync(customerAccount);
            await _context.SaveChangesAsync();

            // Adding customer

            var result = await _context.Account
                .Where(x => x.PasswordSalt == salt)
                .SingleOrDefaultAsync();
            var accountId = result.Id;

            Database.Customer customer = new Database.Customer()
            {
                AccountId = accountId,
                Address = request.Address,
                AreaId = request.AreaId,
                CompanyName = request.CompanyName
            };

            _context.Customer.Add(customer);
            _context.SaveChanges();

            return _mapper.Map<Model.Models.Customer>(customer);
        }
        public async Task<Model.Models.Customer> GetById(int? id)
        {
            if (id == null)
                throw new UserException("ID je obavezan");
            
            var customer = await _context.Customer
                .Include(x => x.Account)
                .Include(x => x.Area)
                .Where(x => x.Id == id)
                .SingleOrDefaultAsync();
            
            if (customer == null)
                throw new UserException("Korisnik nije pronađen");

            return _mapper.Map<Model.Models.Customer>(customer);
        }
        public async Task<Model.Models.Customer> Update(int? id, CustomerUpdateRequest request)
        {
            if (id == null)
                throw new UserException("ID ne može biti prazno polje");

            var entity = await _context.Customer.Include(x => x.Account)
                .Include(x => x.Area).Where(x => x.Id == id).SingleOrDefaultAsync();

            if (entity == null)
                throw new UserException("Korisnik nije pronađen");

            if (!String.IsNullOrWhiteSpace(request.Password))
            {
                if (request.Password == request.PasswordConfirm)
                {
                    entity.Account.PasswordSalt = AccountService.GenerateSalt();
                    entity.Account.PasswordHash = AccountService
                        .GenerateHash(entity.Account.PasswordSalt, request.Password);
                }
                else
                    throw new UserException("Lozinke moraju biti jednake");
            }

            await UpdateEntity(entity, request);

            return _mapper.Map<Model.Models.Customer>(entity);
        }
        public async Task<Model.Models.Customer> Delete(int? id)
        {
            if (id == null)
                throw new UserException("ID ne može biti prazno polje");

            var entity = await _context.Customer.Include(x => x.Account).Include(x => x.Area)
                .Where(x => x.Id == id).SingleOrDefaultAsync();

            if (entity == null)
                throw new UserException("Korisnik nije pronađen");

            entity.Active = false;
            await _context.SaveChangesAsync();

            return _mapper.Map<Model.Models.Customer>(entity);
        }


        private async Task<bool> UpdateEntity(Database.Customer entity, CustomerUpdateRequest request)
        {
            if (request.AreaId != 0) entity.AreaId = request.AreaId;
            if (request.Address != null) entity.Address = request.Address;
            if (request.CompanyName != null) entity.CompanyName = request.CompanyName;
            if (request.Email != null) entity.Account.Email = request.Email;
            if (request.PhoneNumber != null) entity.Account.PhoneNumber = request.PhoneNumber;
            if (request.Username != null) entity.Account.Username = request.Username;

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<Model.Models.Customer> GetByAccountId(int? accountId)
        {
            var entity = await _context.Customer
                .Include(x => x.Area)
                .Include(x => x.Account)
                .SingleOrDefaultAsync(x => x.AccountId == accountId);

            if (entity == null)
                throw new UserException("Klijent sa ovim nalogom ne postoji");

            return _mapper.Map<Model.Models.Customer>(entity);
        }
    }
}