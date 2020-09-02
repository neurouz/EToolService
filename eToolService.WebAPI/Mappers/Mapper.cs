using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace EToolService.WebAPI.Mappers
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            // Mapping classes with CreateMap<> function
            CreateMap<Database.Account, Model.Models.Account>().ReverseMap();
            CreateMap<Database.Customer, Model.Models.Customer>()
                .ForMember(x => x.AreaName, opt => opt.MapFrom(x => x.Area.AreaName))
                .ReverseMap();
            CreateMap<Database.Customer, Model.Requests.CustomerUpdateRequest>()
                .ForMember(x => x.Password, opt => opt.Ignore())
                .ForMember(x => x.PasswordConfirm, opt => opt.Ignore())
                .ReverseMap();

            CreateMap<Database.Employee, Model.Models.Employee>().ReverseMap();
            CreateMap<Database.Machine, Model.Models.Machine>().ReverseMap();
            CreateMap<Database.EmployeeRequest, Model.Models.Request>().ReverseMap();
            CreateMap<Database.Employee, Model.Requests.EmployeeInsertRequest>().ReverseMap();

            CreateMap<Database.EmployeeRequest, Model.Models.Request>().ReverseMap();

            CreateMap<Database.Material, EToolService.Model.Models.Material>().ReverseMap();

            CreateMap<Database.Product, EToolService.Model.Models.Product>().ReverseMap();

            CreateMap<Database.Service, EToolService.Model.Models.Services>()
                .ForMember(x => x.CustomerName, opt => opt.MapFrom(x => x.Customer.CompanyName))
                .ReverseMap();

            CreateMap<Database.ServiceResponse, EToolService.Model.Models.Services>()
                .ReverseMap();

            CreateMap<Database.Order, EToolService.Model.Models.Order>().ReverseMap();

            CreateMap<KeyValuePair<int, Database.Product>, KeyValuePair<int, Model.Models.Product>>()
                .ReverseMap();

            CreateMap<Database.ServiceResponse, EToolService.Model.Models.ServiceResponse>()
                .ReverseMap();

            CreateMap<Database.Area, EToolService.Model.Models.Area>()
                .ReverseMap();
        }
    }
}
