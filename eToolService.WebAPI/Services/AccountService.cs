using AutoMapper;
using EToolService.Model.Models;
using EToolService.WebAPI.Database;
using EToolService.WebAPI.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using AutoMapper.Mappers;
using EToolService.Model.Requests;
using EToolService.WebAPI.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EToolService.WebAPI.Services
{
    public class AccountService : IAccountService
    {
        private readonly Context _context;
        private readonly IMapper _mapper;

        public AccountService(Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }

        public List<Model.Models.Account> GetAll()
        {
            var accounts = _context.Account.ToList();
            return _mapper.Map<List<Model.Models.Account>>(accounts);
        }

        public Model.Models.Account Get(int id)
        {
            var account = _context.Account.SingleOrDefault(acc => acc.Id == id);
            if (account == null)
                throw new UserException("Korisnički nalog nije pronađen");
            
            return _mapper.Map<Model.Models.Account>(account);
        }

        public Model.Models.Account Authenticate(AuthenticateRequest request)
        {
            var user = _context.Account.FirstOrDefault(x => x.Username == request.Username);

            if (user != null)
            {
                var hash = GenerateHash(user.PasswordSalt, request.Password);
                if (hash == user.PasswordHash)
                {
                    return _mapper.Map<Model.Models.Account>(user);
                }
            }

            return null;
        }

        public Model.Models.Account AuthenticateAdmin(AuthenticateRequest request)
        {
            var user = _context.Administrator
                .Include(x => x.Account)
                .FirstOrDefault(x => x.Account.Username == request.Username);

            if (user != null)
            {
                var hash = GenerateHash(user.Account.PasswordSalt, request.Password);
                if (hash == user.Account.PasswordHash)
                {
                    return _mapper.Map<Model.Models.Account>(user.Account);
                }
            }

            return null;
        }
    }
}
