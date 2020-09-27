using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eToolService.WebAPI.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(maxLength: 30, nullable: false),
                    PasswordHash = table.Column<string>(nullable: false),
                    PasswordSalt = table.Column<string>(nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 50, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Area",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AreaName = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Area", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    Position = table.Column<string>(maxLength: 50, nullable: false),
                    ContractSigned = table.Column<DateTime>(type: "datetime", nullable: false),
                    Salary = table.Column<decimal>(type: "money", nullable: false),
                    Active = table.Column<bool>(nullable: false, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Machine",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MachineName = table.Column<string>(maxLength: 50, nullable: false),
                    MachineDescription = table.Column<string>(nullable: false),
                    Purpose = table.Column<string>(maxLength: 255, nullable: false),
                    Type = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Machine", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MaterialType",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(maxLength: 50, nullable: false),
                    Label = table.Column<string>(maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialType", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(type: "money", nullable: false),
                    ImageLocation = table.Column<string>(maxLength: 255, nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Condition = table.Column<string>(maxLength: 20, nullable: false),
                    Discount = table.Column<double>(nullable: false),
                    Active = table.Column<bool>(nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Administrator",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    AccountID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administrator", x => x.ID);
                    table.ForeignKey(
                        name: "fk_administrator_account",
                        column: x => x.AccountID,
                        principalTable: "Account",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(maxLength: 100, nullable: false),
                    Address = table.Column<string>(maxLength: 100, nullable: false),
                    AreaID = table.Column<int>(nullable: false),
                    AccountID = table.Column<int>(nullable: false),
                    Active = table.Column<bool>(nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.ID);
                    table.ForeignKey(
                        name: "fk_customer_account",
                        column: x => x.AccountID,
                        principalTable: "Account",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_customer_area",
                        column: x => x.AreaID,
                        principalTable: "Area",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeMachine",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeID = table.Column<int>(nullable: false),
                    MachineID = table.Column<int>(nullable: false),
                    Level = table.Column<string>(maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeMachine", x => x.ID);
                    table.ForeignKey(
                        name: "fk_employeemachine_employee",
                        column: x => x.EmployeeID,
                        principalTable: "Employee",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_employeemachine_machine",
                        column: x => x.MachineID,
                        principalTable: "Machine",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeRequest",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    Description = table.Column<string>(nullable: true),
                    Purpose = table.Column<string>(maxLength: 255, nullable: false),
                    Phase = table.Column<int>(nullable: false),
                    EmployeeID = table.Column<int>(nullable: false),
                    AdministratorID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeRequest", x => x.ID);
                    table.ForeignKey(
                        name: "fk_employee_request_administrator",
                        column: x => x.AdministratorID,
                        principalTable: "Administrator",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_employee_request_employee",
                        column: x => x.EmployeeID,
                        principalTable: "Employee",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Material",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Diameter = table.Column<decimal>(type: "decimal(18, 0)", nullable: true),
                    Length = table.Column<decimal>(type: "decimal(18, 0)", nullable: true),
                    Width = table.Column<decimal>(type: "decimal(18, 0)", nullable: true),
                    Thickness = table.Column<decimal>(type: "decimal(18, 0)", nullable: true),
                    Quality = table.Column<string>(maxLength: 50, nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Hardness = table.Column<int>(nullable: false),
                    AdministratorID = table.Column<int>(nullable: false),
                    MaterialTypeID = table.Column<int>(nullable: false),
                    Available = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Material", x => x.ID);
                    table.ForeignKey(
                        name: "fk_material_administrator",
                        column: x => x.AdministratorID,
                        principalTable: "Administrator",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_material_materialtype",
                        column: x => x.MaterialTypeID,
                        principalTable: "MaterialType",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ShippingAddress = table.Column<string>(maxLength: 100, nullable: false),
                    ContactNumber = table.Column<string>(maxLength: 30, nullable: false),
                    CustomerID = table.Column<int>(nullable: false),
                    Active = table.Column<bool>(nullable: true, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.ID);
                    table.ForeignKey(
                        name: "fk_order_customer",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Service",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ToolName = table.Column<string>(maxLength: 100, nullable: false),
                    ServiceType = table.Column<string>(maxLength: 30, nullable: false),
                    Note = table.Column<string>(nullable: true),
                    Urgent = table.Column<bool>(nullable: false),
                    Attachment = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    CustomerID = table.Column<int>(nullable: false),
                    Viewed = table.Column<bool>(nullable: true, defaultValue: true),
                    Quantity = table.Column<int>(nullable: false),
                    Responsed = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service", x => x.ID);
                    table.ForeignKey(
                        name: "fk_service_customer",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductOrder",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductID = table.Column<int>(nullable: false),
                    OrderID = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductOrder", x => x.ID);
                    table.ForeignKey(
                        name: "fk_productorder_order",
                        column: x => x.OrderID,
                        principalTable: "Order",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_productorder_product",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ServiceResponse",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdministratorID = table.Column<int>(nullable: false),
                    ServiceID = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(type: "money", nullable: false),
                    FinishDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Approved = table.Column<bool>(nullable: false),
                    Explanation = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceResponse", x => x.ID);
                    table.ForeignKey(
                        name: "fk_serviceresponse_administrator",
                        column: x => x.AdministratorID,
                        principalTable: "Administrator",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_serviceresponse_service",
                        column: x => x.ServiceID,
                        principalTable: "Service",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Administrator_AccountID",
                table: "Administrator",
                column: "AccountID");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_AccountID",
                table: "Customer",
                column: "AccountID");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_AreaID",
                table: "Customer",
                column: "AreaID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeMachine_EmployeeID",
                table: "EmployeeMachine",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeMachine_MachineID",
                table: "EmployeeMachine",
                column: "MachineID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeRequest_AdministratorID",
                table: "EmployeeRequest",
                column: "AdministratorID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeRequest_EmployeeID",
                table: "EmployeeRequest",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Material_AdministratorID",
                table: "Material",
                column: "AdministratorID");

            migrationBuilder.CreateIndex(
                name: "IX_Material_MaterialTypeID",
                table: "Material",
                column: "MaterialTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CustomerID",
                table: "Order",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductOrder_OrderID",
                table: "ProductOrder",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductOrder_ProductID",
                table: "ProductOrder",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Service_CustomerID",
                table: "Service",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceResponse_AdministratorID",
                table: "ServiceResponse",
                column: "AdministratorID");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceResponse_ServiceID",
                table: "ServiceResponse",
                column: "ServiceID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeMachine");

            migrationBuilder.DropTable(
                name: "EmployeeRequest");

            migrationBuilder.DropTable(
                name: "Material");

            migrationBuilder.DropTable(
                name: "ProductOrder");

            migrationBuilder.DropTable(
                name: "ServiceResponse");

            migrationBuilder.DropTable(
                name: "Machine");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "MaterialType");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Administrator");

            migrationBuilder.DropTable(
                name: "Service");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "Area");
        }
    }
}
