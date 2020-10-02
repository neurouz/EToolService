using AutoMapper;
using EToolService.Model.Requests;
using EToolService.WebAPI.Database;
using EToolService.WebAPI.Exceptions;
using EToolService.WebAPI.Services;
using EToolService.WebAPI.Services.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using Xunit;

namespace EToolService.UnitTest
{

    public class APIFactory : WebApplicationFactory<WebAPI.Startup>
    {
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureAppConfiguration(config =>
            {
                var integrationConfig = new ConfigurationBuilder()
                  .AddJsonFile("IntegrationSettings.json")
                  .Build();

                config.AddConfiguration(integrationConfig);
            });

            builder.ConfigureTestServices(services =>
            {
                services.AddAutoMapper(typeof(WebAPI.Startup));
            });

        }
    }
    public class APITest : IClassFixture<APIFactory>
    {
        private IAccountService _accountService;
        private ICustomerService _customerService;
        private IEmployeeService _employeeService;
        private IMaterialService _materialService;
        private IOrderService _orderService;
        private IProductService _productService;
        private RecommenderService _recommenderService;
        private IReportService _reportService;
        private IRequestsService _requestsService;
        private IToolService _toolService;
        private Context _context;
        private IMapper _mapper;

        private HttpClient _client;

        public APITest(APIFactory fixture)
        {
            _context = new Context();
            var options = new DbContextOptionsBuilder<Context>()
             .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
             .Options;

            var mapperConfiguration = new MapperConfiguration(cfg =>
                cfg.AddProfile(new WebAPI.Mappers.Mapper()));

            _mapper = new Mapper(mapperConfiguration);

            _context = new Context(options);

            DbInitializer.Seed(_context);

            Init();

            _client = fixture.CreateClient();
           
        }

        private void Init()
        {
            _accountService = new AccountService(_context, _mapper);
        }

        [Fact]
        public void AccountServiceTest()
        {
            var exception = Assert.Throws<UserException>(() => _accountService.Get(-5));
            Assert.Equal("Korisnički nalog nije pronađen", exception.Message);

            Assert.Equal("desktop", _accountService.Get(1).Username);

            // Nepostojeci username i password vraca NULL
            var authenticateRequest = new AuthenticateRequest()
            {
                Username = "ne_postoji",
                Password = "ne_postoji"
            };
            Assert.Null(_accountService.Authenticate(authenticateRequest));

            // Postojeci username i password vraca objekat tipa Account
            var authRequest = new AuthenticateRequest()
            {
                Username = "mobile",
                Password = "test"
            };
            Assert.IsType<Model.Models.Account>(_accountService.Authenticate(authRequest));
        }

        [Fact]
        public void ReportServiceTest()
        {
            // TODO
        }
    }

}
