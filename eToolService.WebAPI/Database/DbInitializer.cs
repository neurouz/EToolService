using EToolService.WebAPI.Services;
using EToolService.Model.Enumerations;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EToolService.WebAPI.Database
{
    public class DbInitializer
    {
        private static string[] _serviceTypes = { "Oštrenje", "Reparacija" };
        private static bool[] _urgents = { true, false };
        private static string[] _extensions = { ".pdf", ".png", ".docx", ".txt" };
        public static void Seed(Context context)
        {
            AddAreas(context);
            AddProducts(context);
            AddEmployees(context);
            AddMaterialTypes(context);
            AddMachines(context);
            AddEmployeeMachines(context);
            AddAdministratorWithAccount(context);
            AddCustomerWithAccounts(context);
            AddEmployeeRequests(context);
            AddMaterial(context);
            AddOrders(context);
            AddProductOrders(context);
            AddServices(context);
            AddServiceResponses(context);
        }

        private static int GetRandomId(int to)
        {
            var rand = new Random();
            return rand.Next(1, to);
        }
        private static int GetRandomInt(int from, int to)
        {
            var rand = new Random();
            return rand.Next(from, to);
        }
        private static DateTime GetRandomDate()
        {
            return new DateTime(year: GetRandomInt(2018, 2020),
                month: GetRandomInt(1, 13),
                day: GetRandomInt(1, 29));
        }
        private static string GetRandomPhoneNumber()
        {
            return "0" + GetRandomInt(61, 67).ToString() + "/"
                + GetRandomInt(100, 999).ToString()
                + "-" + GetRandomInt(100, 999);
        }
        private static decimal GetRandomPrice()
        {
            return decimal.Parse((string.Format("{0:0.##}", new Random().NextDouble() * 100)));
        }

        // 6 Products
        private static void AddProducts(Context context)
        {
            if (context.Product.ToList().Count > 0)
                return;
            context.Product.AddRange(
                new Product { ProductName = "Spiralno glodalo", Condition = "Novo", Description = "D20X82 Z4 Fino", Discount = 0.1, ImageLocation = "spiralno_glodalo.jpg", Price = 459.00m },
                new Product { ProductName = "Kružna žaga", Condition = "Novo", Description = "D700X4.5 Z76", Discount = 0.05, ImageLocation = "kruzna_zaga.jpg", Price = 99.90m },
                new Product { ProductName = "Profilno glodalo", Condition = "Polovno", Description = "D200X35 Z6 Fino", ImageLocation = "profilno_glodalo.jpg", Price = 1000.00m },
                new Product { ProductName = "Burgija", Condition = "Novo", Description = "D6X15 Z2 L/D", Discount = 0.4, ImageLocation = "burgija.jpg", Price = 24.90m },
                new Product { ProductName = "Upuštač", Condition = "Novo", Description = "D16X45 Z3 Fino", ImageLocation = "upustac.jpg", Price = 15.55m },
                new Product { ProductName = "Mini-Cink", Condition = "Polovno", Description = "D160X3.4 Z4", Discount = 0.025, ImageLocation = "mini_cink.jpg", Price = 110.00m }
            );
            context.SaveChanges();
            Console.WriteLine("Products added");
        }
        // 6 Areas
        private static void AddAreas(Context context)
        {
            if (context.Area.ToList().Count > 0)
                return;
            context.Area.AddRange(
                new Area { AreaName = "Proizvodnja namještaja" },
                new Area { AreaName = "Obrada metala i metalnih proizvoda" },
                new Area { AreaName = "Proizvodnja PVC stolarije" },
                new Area { AreaName = "Razno" },
                new Area { AreaName = "Obrada stiropora i plastike" },
                new Area { AreaName = "Proizvodnja pločastog namještaja" }
            );
            context.SaveChanges();
            Console.WriteLine("Areas added");
        }
        // 19 Employees
        private static void AddEmployees(Context context)
        {
            if (context.Employee.ToList().Count > 0)
                return;
            context.Employee.AddRange(
                new Employee { Active = true, ContractSigned = DateTime.Now, FirstName = "Ajdin", LastName = "Hukara", Position = "CNC Programer", Salary = 1950m},
                new Employee { Active = true, ContractSigned = DateTime.Now, FirstName = "Emir", LastName = "Zukic", Position = "CNC Operater", Salary = 850m},
                new Employee { Active = true, ContractSigned = DateTime.Now, FirstName = "Samid", LastName = "Razanica", Position = "CAM/CAD programer", Salary = 950m},
                new Employee { Active = false, ContractSigned = DateTime.Now, FirstName = "Armin", LastName = "Music", Position = "Konstruktor na računaru", Salary = 1000m},
                new Employee { Active = true, ContractSigned = DateTime.Now, FirstName = "Mustafa", LastName = "Nadarevic", Position = "Inženjer", Salary = 2400m},
                new Employee { Active = true, ContractSigned = DateTime.Now, FirstName = "Edib", LastName = "Sijercic", Position = "CNC Programer", Salary = 1950m},
                new Employee { Active = false, ContractSigned = DateTime.Now, FirstName = "Aida", LastName = "Monteno", Position = "Inženjer", Salary = 2550m},
                new Employee { Active = true, ContractSigned = DateTime.Now, FirstName = "Muhamed", LastName = "Beslic", Position = "CNC Operater", Salary = 900m},
                new Employee { Active = true, ContractSigned = DateTime.Now, FirstName = "Ivan", LastName = "Hadziabdic", Position = "CNC Operater", Salary = 950m},
                new Employee { Active = true, ContractSigned = DateTime.Now, FirstName = "Adisa", LastName = "Mulic", Position = "Inženjer", Salary = 2000m},
                new Employee { Active = true, ContractSigned = DateTime.Now, FirstName = "Maid", LastName = "Hasanagic", Position = "Serviser", Salary = 700m},
                new Employee { Active = false, ContractSigned = DateTime.Now, FirstName = "Edib", LastName = "Hasic", Position = "Serviser", Salary = 750m},
                new Employee { Active = true, ContractSigned = DateTime.Now, FirstName = "Kemal", LastName = "Curić", Position = "Magacioner", Salary = 625m},
                new Employee { Active = true, ContractSigned = DateTime.Now, FirstName = "Senad", LastName = "Aleta", Position = "Lotar", Salary = 715m},
                new Employee { Active = true, ContractSigned = DateTime.Now, FirstName = "Faruk", LastName = "Kapidzic", Position = "Lotar", Salary = 758m},
                new Employee { Active = false, ContractSigned = DateTime.Now, FirstName = "Sanin", LastName = "Selimovic", Position = "Magacioner", Salary = 600m},
                new Employee { Active = true, ContractSigned = DateTime.Now, FirstName = "Alem", LastName = "Forto", Position = "CNC Operater", Salary = 1100m},
                new Employee { Active = false, ContractSigned = DateTime.Now, FirstName = "Edina", LastName = "Bosnjak", Position = "Konstruktor na računaru", Salary = 1350m},
                new Employee { Active = false, ContractSigned = DateTime.Now, FirstName = "Merima", LastName = "Zukic", Position = "Serviser", Salary = 955m }
                );
            context.SaveChanges();
            Console.WriteLine("Employees added");
        }
        // 3 Material types
        private static void AddMaterialTypes(Context context)
        {
            if (context.MaterialType.ToList().Count > 0)
                return;
            context.MaterialType.AddRange(
                new MaterialType { TypeName = "Šipkasti materijal", Label = "SM" },
                new MaterialType { TypeName = "Aluminijum", Label = "AL"},
                new MaterialType { TypeName = "Čelik", Label = "Č"}
            );
            context.SaveChanges();
            Console.WriteLine("Material types added");
        }
        // 8 Machines
        private static void AddMachines(Context context)
        {
            if (context.Machine.ToList().Count > 0)
                return;
            context.Machine.AddRange(
                new Machine { MachineName = "Walter Helitronic Basic", MachineDescription = "Petoosna brusilica sa 100% uljnim hlađenjem" , Purpose = "Servis i proizvodnja spiralnih glodala", Type = "CNC Brusilica"},
                new Machine { MachineName = "Leadwell VE", MachineDescription = "Glodalica sa tri ose, mogucnost dodavanja cetvrte ose za kruznu obradu" , Purpose = "Obrada svih vrsta materijala", Type = "CNC Glodalica"},
                new Machine { MachineName = "Haas ST-50", MachineDescription = "Strug za obradu metala, max prečnik: 750mm, tri pakne" , Purpose = "Obrada i priprema metala za glodalice", Type = "CNC Strug"},
                new Machine { MachineName = "SXC Europe SBC 220", MachineDescription = "Mašina za pjeskarenje namjenjena za zaštitu metala od korozije i ljepši izgled nakon farbanja" , Purpose = "Zaštita metala", Type = "Ručni pjeskač"},
                new Machine { MachineName = "Glodalica za metal", MachineDescription = "Ručna glodalica sa četiri ose" , Purpose = "Priprema metala za CNC glodalice", Type = "NC Glodalica"},
                new Machine { MachineName = "TOS Glodalica za metal", MachineDescription = "Ručna glodalica sa pet osa" , Purpose = "Priprema metala za finu obradu", Type = "NC Glodalica"},
                new Machine { MachineName = "CNC ALG 400", MachineDescription = "Prvomajska glodalica sa 4 ose" , Purpose = "Priprema metala za finu obradu", Type = "NC Glodalica"},
                new Machine { MachineName = "Mašina za poliranje", MachineDescription = "Mašina za poliranje, max. prečnik: 500mm" , Purpose = "Poliranje žaga i mini-cinka prije farbanja", Type = "Ručna mašina za poliranje"}
            );
            context.SaveChanges();
            Console.WriteLine("Machines added");
        }
        // 32 Employee machines
        private static void AddEmployeeMachines(Context context)
        {
            if (context.EmployeeMachine.ToList().Count > 0)
                return;
            context.EmployeeMachine.AddRange(
                new EmployeeMachine { EmployeeId = GetRandomId(19), MachineId = GetRandomId(8)},
                new EmployeeMachine { EmployeeId = GetRandomId(19), MachineId = GetRandomId(8) },
                new EmployeeMachine { EmployeeId = GetRandomId(19), MachineId = GetRandomId(8) },
                new EmployeeMachine { EmployeeId = GetRandomId(19), MachineId = GetRandomId(8) },
                new EmployeeMachine { EmployeeId = GetRandomId(19), MachineId = GetRandomId(8) },
                new EmployeeMachine { EmployeeId = GetRandomId(19), MachineId = GetRandomId(8) },
                new EmployeeMachine { EmployeeId = GetRandomId(19), MachineId = GetRandomId(8) },
                new EmployeeMachine { EmployeeId = GetRandomId(19), MachineId = GetRandomId(8) },
                new EmployeeMachine { EmployeeId = GetRandomId(19), MachineId = GetRandomId(8) },
                new EmployeeMachine { EmployeeId = GetRandomId(19), MachineId = GetRandomId(8) },
                new EmployeeMachine { EmployeeId = GetRandomId(19), MachineId = GetRandomId(8) },
                new EmployeeMachine { EmployeeId = GetRandomId(19), MachineId = GetRandomId(8) },
                new EmployeeMachine { EmployeeId = GetRandomId(19), MachineId = GetRandomId(8) },
                new EmployeeMachine { EmployeeId = GetRandomId(19), MachineId = GetRandomId(8) },
                new EmployeeMachine { EmployeeId = GetRandomId(19), MachineId = GetRandomId(8) },
                new EmployeeMachine { EmployeeId = GetRandomId(19), MachineId = GetRandomId(8) },
                new EmployeeMachine { EmployeeId = GetRandomId(19), MachineId = GetRandomId(8) },
                new EmployeeMachine { EmployeeId = GetRandomId(19), MachineId = GetRandomId(8) },
                new EmployeeMachine { EmployeeId = GetRandomId(19), MachineId = GetRandomId(8) },
                new EmployeeMachine { EmployeeId = GetRandomId(19), MachineId = GetRandomId(8) },
                new EmployeeMachine { EmployeeId = GetRandomId(19), MachineId = GetRandomId(8) },
                new EmployeeMachine { EmployeeId = GetRandomId(19), MachineId = GetRandomId(8) },
                new EmployeeMachine { EmployeeId = GetRandomId(19), MachineId = GetRandomId(8) },
                new EmployeeMachine { EmployeeId = GetRandomId(19), MachineId = GetRandomId(8) },
                new EmployeeMachine { EmployeeId = GetRandomId(19), MachineId = GetRandomId(8) },
                new EmployeeMachine { EmployeeId = GetRandomId(19), MachineId = GetRandomId(8) },
                new EmployeeMachine { EmployeeId = GetRandomId(19), MachineId = GetRandomId(8) },
                new EmployeeMachine { EmployeeId = GetRandomId(19), MachineId = GetRandomId(8) },
                new EmployeeMachine { EmployeeId = GetRandomId(19), MachineId = GetRandomId(8) },
                new EmployeeMachine { EmployeeId = GetRandomId(19), MachineId = GetRandomId(8) },
                new EmployeeMachine { EmployeeId = GetRandomId(19), MachineId = GetRandomId(8) },
                new EmployeeMachine { EmployeeId = GetRandomId(19), MachineId = GetRandomId(8) }
            );
            context.SaveChanges();
            Console.WriteLine("Employee machines added");
        }
        // Adding 1 administrator + account (user: Admin, pw: GlavniAdmin)
        private static void AddAdministratorWithAccount(Context context)
        {
            if (context.Administrator.ToList().Count > 0)
                return;

            var salt = AccountService.GenerateSalt();
            var hash = AccountService.GenerateHash(salt, "test");

            context.Account.Add(new Account
            {
                DateCreated = DateTime.Now,
                Email = "ajdin.hukara@edu.fit.ba",
                PasswordSalt = salt,
                PasswordHash = hash,
                PhoneNumber = "061/550-134",
                Username = "desktop"
            });
            context.SaveChanges();

            int adminId = context.Account.Where(x => x.Username == "desktop").SingleOrDefault().Id;

            context.Administrator.AddRange(
                new Administrator
                {
                    AccountId = adminId,
                    FirstName = "Ajdin",
                    LastName = "Hukara"
                }
            );

            context.SaveChanges();
            Console.WriteLine("Administrator added");
        }
        // Adding 2 customers + customer accounts
        private static void AddCustomerWithAccounts(Context context)
        {
            if (context.Customer.ToList().Count > 0)
                return;

            // Customer 1 - MDG International
            var salt = AccountService.GenerateSalt();
            var hash = AccountService.GenerateHash(salt, "test");

            context.Account.Add(new Account
            {
                DateCreated = DateTime.Now,
                Email = "samir.music@mdg.ba",
                PasswordSalt = salt,
                PasswordHash = hash,
                PhoneNumber = "063/023-412",
                Username = "mobile"
            });
            context.SaveChanges();

            int mdgAccountId = context.Account.
                Where(x => x.Username == "mobile").SingleOrDefault().Id;

            context.Customer.Add(new Customer
            {
                CompanyName = "MDG International",
                Address = "Josanicka bb",
                AreaId = GetRandomId(7),
                AccountId = mdgAccountId
            });

            context.SaveChanges();

            // Customer 2 - ZEC Mostar
            salt = AccountService.GenerateSalt();
            hash = AccountService.GenerateHash(salt, "zec-password");

            context.Account.Add(new Account
            {
                DateCreated = DateTime.Now,
                Email = "podrska@zecmostar.ba",
                PasswordSalt = salt,
                PasswordHash = hash,
                PhoneNumber = "033/800-400",
                Username = "ZecMostar"
            });
            context.SaveChanges();

            int zecAccountId = context.Account.
                Where(x => x.Username == "ZecMostar").SingleOrDefault().Id;

            context.Customer.Add(new Customer
            {
                CompanyName = "ZEC Mostar",
                Address = "Slobodna carinska zona Rodoč bb",
                AreaId = GetRandomId(7),
                AccountId = zecAccountId
            });

            context.SaveChanges();
            Console.WriteLine("Customers added");
        }
        // 6 Employee requests
        private static void AddEmployeeRequests(Context context)
        {
            if (context.EmployeeRequest.ToList().Count > 0)
                return;

            // Phase: 1(Odobren), 2(Odbijen), 3(U razmatranju)
            int adminId = context.Account.Where(x => x.Username == "desktop").SingleOrDefault().Id;

            context.EmployeeRequest.AddRange(
                new EmployeeRequest
                {
                    DateCreated = DateTime.Now,
                    Description = "Poštovani, zamolio bih Vas da mi odobrite zahtjev za izmjenu godišnjeg odmora u periodu od 28.8.2020",
                    Purpose = "Zahtjev za izmjenu godišnjeg odmora",
                    Phase = 3,
                    EmployeeId = GetRandomId(20),
                    AdministratorId = adminId
                },
                new EmployeeRequest
                {
                    DateCreated = DateTime.Now,
                    Description = "Poštovani, zamolio bih Vas da mi odobrite zahtjev za potvrdu o radnom stažu",
                    Purpose = "Zahtjev za potvrdu o radnom stažu",
                    Phase = 3,
                    EmployeeId = GetRandomId(20),
                    AdministratorId = adminId
                },
                new EmployeeRequest
                {
                    DateCreated = DateTime.Now,
                    Description = "Poštovani, zamolio bih Vas da mi odobrite zahtjev za produženjem radne dozvole u svrhu obrade kredita",
                    Purpose = "Zahtjev o produženju radne dozvole",
                    Phase = 3,
                    EmployeeId = GetRandomId(20),
                    AdministratorId = adminId
                },
                new EmployeeRequest
                {
                    DateCreated = DateTime.Now,
                    Description = "Poštovani, zamolio bih Vas da mi odobrite zahtjev za izdavanje porezne kartice",
                    Purpose = "Zahtjev za izdavanje porezne kartice",
                    Phase = 3,
                    EmployeeId = GetRandomId(20),
                    AdministratorId = adminId
                },
                new EmployeeRequest
                {
                    DateCreated = DateTime.Now,
                    Description = "Poštovani, zamolio bih Vas da mi odobrite zahtjev za potvrdu o radnom stažu",
                    Purpose = "Zahtjev za potvrdu o radnom stažu",
                    Phase = 3,
                    EmployeeId = GetRandomId(20),
                    AdministratorId = adminId
                },
                new EmployeeRequest
                {
                    DateCreated = DateTime.Now,
                    Description = "Poštovani, zamolio bih Vas da mi odobrite zahtjev za izdavanje porezne kartice",
                    Purpose = "Zahtjev za izdavanje porezne kartice",
                    Phase = 3,
                    EmployeeId = GetRandomId(20),
                    AdministratorId = adminId
                }
            );
            context.SaveChanges();
            Console.WriteLine("Requests added");
        }
        // 10 Materials
        private static void AddMaterial(Context context)
        {
            if (context.Material.ToList().Count > 0)
                return;

            int adminId = context.Account.Where(x => x.Username == "desktop").SingleOrDefault().Id;

            context.Material.AddRange(new Material
            {
                MaterialTypeId = (int)MaterialTypes.BarMaterial, // Šipkasti materijal
                Diameter = 20,
                Length = 330,
                Quality = "HM",
                Quantity = 20,
                Hardness = 300,
                AdministratorId = adminId,
                Available = true
            },
            new Material
            {
                MaterialTypeId = (int)MaterialTypes.BarMaterial, // Šipkasti materijal
                Diameter = 16,
                Length = 330,
                Quality = "HSS",
                Quantity = 20,
                Hardness = 300,
                AdministratorId = adminId,
                Available = true
            },
            new Material
            {
                MaterialTypeId = (int)MaterialTypes.BarMaterial, // Šipkasti materijal
                Diameter = 14,
                Length = 330,
                Quality = "HM",
                Quantity = 20,
                Hardness = 280,
                AdministratorId = adminId,
                Available = true
            },
            new Material
            {
                MaterialTypeId = (int)MaterialTypes.BarMaterial, // Šipkasti materijal
                Diameter = 12,
                Length = 330,
                Quality = "HM",
                Quantity = 20,
                Hardness = 280,
                AdministratorId = adminId,
                Available = true
            },
            new Material
            {
                MaterialTypeId = (int)MaterialTypes.BarMaterial, // Šipkasti materijal
                Diameter = 10,
                Length = 330,
                Quality = "HSS",
                Quantity = 20,
                Hardness = 260,
                AdministratorId = adminId,
                Available = true
            },
            new Material
            {
                MaterialTypeId = (int)MaterialTypes.BarMaterial, // Šipkasti materijal
                Diameter = 25,
                Length = 330,
                Quality = "HM",
                Quantity = 10,
                Hardness = 310,
                AdministratorId = adminId,
                Available = true
            },
            new Material
            {
                MaterialTypeId = (int)MaterialTypes.Aluminum, // Aluminijum
                Width = 1000,
                Thickness = 50,
                Length = 330,
                Quality = "AL",
                Quantity = 10,
                Hardness = 300,
                AdministratorId = adminId,
                Available = true
            },
            new Material
            {
                MaterialTypeId = (int)MaterialTypes.Steel, // Čelik
                Width = 500,
                Thickness = 55,
                Length = 5000,
                Quality = "Č.0371",
                Quantity = 2,
                Hardness = 300,
                AdministratorId = adminId,
                Available = true
            },
            new Material
            {
                MaterialTypeId = (int)MaterialTypes.Steel, // Čelik
                Width = 420,
                Thickness = 20,
                Length = 3500,
                Quality = "Č.0377",
                Quantity = 5,
                Hardness = 300,
                AdministratorId = adminId,
                Available = true
            },
            new Material
            {
                MaterialTypeId = (int)MaterialTypes.BarMaterial, // Šipkasti materijal
                Diameter = 170,
                Length = 3.7m,
                Quality = "Č.0773",
                Quantity = 500,
                Hardness = 300,
                AdministratorId = adminId,
                Available = true
            }
            );
            context.SaveChanges();
            Console.WriteLine("Materials added");
        }
        // 25 Orders
        private static void AddOrders(Context context)
        {
            if (context.Order.ToList().Count > 0)
                return;

            for(int i=0; i<10; i++)
            {
                int randomCustomer = context.Customer.Where(x => x.Id == GetRandomId(3)).SingleOrDefault().Id;
                context.Order.Add(new Order
                {
                    OrderDate = GetRandomDate(),
                    CustomerId = randomCustomer,
                    ShippingAddress = context.Customer.Where(x => x.Id == randomCustomer).SingleOrDefault().Address,
                    ContactNumber = GetRandomPhoneNumber()
                });
                context.SaveChanges();
            }
            Console.WriteLine("Orders added");
        }
        // 1500 Product orders
        private static void AddProductOrders(Context context)
        {
            if (context.ProductOrder.ToList().Count > 0)
                return;

            Console.WriteLine("Seeding table 'ProductOrder'");

            for (int i = 1; i < 7; i++)
                context.ProductOrder.Add(new ProductOrder
                {
                    ProductId = i,
                    OrderId = 1,
                    Quantity = GetRandomInt(1, 20)
                });

            for (int i = 2; i < 5; i++)
                context.ProductOrder.Add(new ProductOrder
                {
                    ProductId = i,
                    OrderId = 2,
                    Quantity = GetRandomInt(1, 20)
                });

            for (int i = 4; i < 6; i++)
                context.ProductOrder.Add(new ProductOrder
                {
                    ProductId = i,
                    OrderId = 3,
                    Quantity = GetRandomInt(1, 20)
                });

            for (int i = 1; i < 2; i++)
                context.ProductOrder.Add(new ProductOrder
                {
                    ProductId = i,
                    OrderId = 4,
                    Quantity = GetRandomInt(1, 20)
                });

            for (int i = 1; i < 4; i++)
                context.ProductOrder.Add(new ProductOrder
                {
                    ProductId = i,
                    OrderId = 5,
                    Quantity = GetRandomInt(1, 20)
                });

            for (int i = 2; i < 7; i++)
                context.ProductOrder.Add(new ProductOrder
                {
                    ProductId = i,
                    OrderId = 6,
                    Quantity = GetRandomInt(1, 20)
                });

            for (int i = 4; i < 7; i++)
                context.ProductOrder.Add(new ProductOrder
                {
                    ProductId = i,
                    OrderId = 7,
                    Quantity = GetRandomInt(1, 20)
                });

            for (int i = 1; i < 5; i++)
                context.ProductOrder.Add(new ProductOrder
                {
                    ProductId = i,
                    OrderId = 8,
                    Quantity = GetRandomInt(1, 20)
                });

            for (int i = 1; i < 3; i++)
                context.ProductOrder.Add(new ProductOrder
                {
                    ProductId = i,
                    OrderId = 9,
                    Quantity = GetRandomInt(1, 20)
                });

            for (int i = 4; i < 6; i++)
                context.ProductOrder.Add(new ProductOrder
                {
                    ProductId = i,
                    OrderId = 10,
                    Quantity = GetRandomInt(1, 20)
                });

            context.SaveChanges();
            Console.WriteLine("ProductOrder added");
        }
        // 2500 Services
        private static void AddServices(Context context)
        {
            if (context.Service.ToList().Count > 0)
                return;
            Console.WriteLine("Adding services");
            for (int i = 1; i <= 50; i++)
            {
                context.Service.Add(new Service
                {
                    ToolName = context.Product.Where(x => x.Id == GetRandomId(7)).SingleOrDefault().ProductName,
                    ServiceType = _serviceTypes[GetRandomInt(0,2)],
                    Urgent = _urgents[GetRandomInt(0,2)],
                    DateCreated = GetRandomDate(),
                    CustomerId = GetRandomId(3),
                    Viewed = true,
                    Quantity = GetRandomInt(1,15), 
                    Responsed = true
                });
            }
            context.SaveChanges();
            Console.WriteLine("\nServices added");

            var services = context.Service.OrderByDescending(x => x.DateCreated).ToList();
            for (int i = 0; i < 5; i++)
            {
                services[i].Viewed = false;
                services[i].Responsed = false;

                var attachment = "attachment_"
                                 + services[i].Id.ToString() + _extensions[GetRandomInt(0, 4)];

                var path = Path.Combine(Directory.GetCurrentDirectory(), "Data", "ServiceAttachments", $"{attachment}");

                File.Create(path);

                services[i].Attachment = attachment;
            }
            context.SaveChanges();
        }
        // 2500 Service responses
        private static void AddServiceResponses(Context context)
        {
            if (context.ServiceResponse.ToList().Count > 0)
                return;

            Console.WriteLine("Adding service responses");

            for (int i = 1; i <= 50; i++)
            {
                context.ServiceResponse.Add(new ServiceResponse
                {
                    AdministratorId = 1,
                    ServiceId = i,
                    Price = GetRandomPrice(),
                    FinishDate = GetRandomDate(),
                    Approved = _urgents[GetRandomInt(0, 2)],
                    Explanation = "Database test explanation"
                });
            }
            context.SaveChanges();
            Console.WriteLine("\nService responses added");

            var query = context.ServiceResponse.Include(x => x.Service)
                .OrderByDescending(x => x.Service.DateCreated)
                .Take(5);

            context.ServiceResponse.AttachRange(query);
            context.ServiceResponse.RemoveRange(query);
            context.SaveChanges();
        }
    }
}
