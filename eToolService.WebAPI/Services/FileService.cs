using AutoMapper;
using EToolService.WebAPI.Database;
using EToolService.WebAPI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EToolService.WebAPI.Services
{
    public class FileService : IFileService
    {
        private readonly Context _context;
        private readonly IMapper _mapper;
        public FileService(Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
    }
}
