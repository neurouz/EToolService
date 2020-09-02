using AutoMapper;
using EToolService.Model.Models;
using EToolService.WebAPI.Database;
using EToolService.Model.Enumerations;
using EToolService.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EToolService.WebAPI.Exceptions;
using EToolService.WebAPI.Services.Interfaces;

namespace EToolService.WebAPI.Services
{
    public class MaterialService : IMaterialService
    {
        private readonly Context _context;
        private readonly IMapper _mapper;
        public MaterialService(Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<EToolService.Model.Models.Material> Get(MaterialSearchRequest request)
        {
            var query = _context.Material
                .Where(x => x.Available == request.isAvailable).AsQueryable();
            if(request.type != MaterialTypes.All)
            {
                query = query
                    .Where(x => x.MaterialTypeId == (int)request.type);
            }
            var materials = query.ToList();
            return _mapper.Map<List<EToolService.Model.Models.Material>>(materials);
        }

        public EToolService.Model.Models.Material Post(MaterialInsertRequest request)
        {
            Database.Material material = new Database.Material
            {
                AdministratorId = 1,
                Available = true,
                Diameter = request.Diameter,
                Hardness = request.Hardness,
                Length = request.Length,
                MaterialTypeId = request.MaterialTypeId,
                Quality = request.Quality,
                Quantity = request.Quantity,
                Thickness = request.Thickness,
                Width = request.Width
            };

            var result = _context.Material.Add(material);
            _context.SaveChanges();
            return _mapper.Map<EToolService.Model.Models.Material>(result.Entity);
        }

        public EToolService.Model.Models.Material Patch(int? id)
        {
            var result = _context.Material.Find(id);

            if (result == null)
                throw new UserException("Materijal nije pronadjen");
            if(!result.Available)
                throw new UserException("Materijal je već potrošen");

            result.Available = false;
            _context.SaveChanges();
            return _mapper.Map<EToolService.Model.Models.Material>(result);
        }
    }
}
