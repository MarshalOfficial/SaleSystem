using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SaleSystemCore.Migrations
{
    public partial class in1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 150, nullable: true),
                    LastName = table.Column<string>(maxLength: 150, nullable: true),
                    Mobile = table.Column<string>(maxLength: 150, nullable: true),
                    Tel = table.Column<string>(maxLength: 150, nullable: true),
                    Address = table.Column<string>(maxLength: 1000, nullable: true),
                    Instagram = table.Column<string>(maxLength: 150, nullable: true),
                    Email = table.Column<string>(maxLength: 150, nullable: true),
                    Description = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: true),
                    MarriageDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GlobalSetting",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    SaleInvoiceCounter = table.Column<long>(nullable: false),
                    PurchaseInvoiceCounter = table.Column<long>(nullable: false),
                    StockAdjustmentInvoiceCounter = table.Column<long>(nullable: false),
                    ProductBarcodeCounter = table.Column<long>(nullable: false),
                    SelectedLanguage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GlobalSetting", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    PermKey = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(maxLength: 250, nullable: true),
                    Barcode = table.Column<string>(maxLength: 500, nullable: true),
                    SalePrice = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    PurchasePrice = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    ProfitMarkup = table.Column<decimal>(nullable: true, computedColumnSql: "((isnull(SalePrice,0) - isnull(PurchasePrice,0))/isnull(PurchasePrice,0))*100"),
                    ProfitMargin = table.Column<decimal>(nullable: true, computedColumnSql: "((isnull(SalePrice,0) - isnull(PurchasePrice,0))/isnull(SalePrice,0))*100"),
                    Discount = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Vat = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Description = table.Column<string>(nullable: true),
                    BrandID = table.Column<int>(nullable: true),
                    CategoryID = table.Column<int>(nullable: true),
                    ProviderID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductsBrand",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    Title = table.Column<string>(maxLength: 150, nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsBrand", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductsCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    Title = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductsProvider",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(maxLength: 150, nullable: true),
                    CompnayName = table.Column<string>(maxLength: 150, nullable: true),
                    Mobile = table.Column<string>(maxLength: 50, nullable: true),
                    Tel = table.Column<string>(maxLength: 100, nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Email = table.Column<string>(maxLength: 150, nullable: true),
                    RegistrationNo = table.Column<string>(maxLength: 250, nullable: true),
                    NationalCode = table.Column<string>(maxLength: 150, nullable: true),
                    BankAccountInfo = table.Column<string>(maxLength: 150, nullable: true),
                    OnlinePaymentUrl = table.Column<string>(maxLength: 500, nullable: true),
                    OnlinePaymentUrlApiKey = table.Column<string>(maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsProvider", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseInvoice",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    InvoiceNumber = table.Column<string>(maxLength: 150, nullable: true),
                    InvoiceDate = table.Column<DateTime>(nullable: true),
                    UserID = table.Column<int>(nullable: false),
                    InvoiceType = table.Column<int>(nullable: false),
                    ProviderID = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    SumPrice = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    SumDiscount = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    SumVat = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    FinalPrice = table.Column<decimal>(nullable: true, computedColumnSql: "(isnull(SumPrice,0) + isnull(SumVat,0)) - isnull(SumDiscount,0) ")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseInvoice", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseInvoiceDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    InvoiceID = table.Column<int>(nullable: false),
                    ProductID = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Qty = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Vat = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Description = table.Column<string>(nullable: true),
                    RowPrice = table.Column<decimal>(nullable: true, computedColumnSql: "qty * ((((100-isnull(discount,0)) * isnull(Price,0))/100) + ((isnull(Vat,0) * isnull(Price,0))/100)) ")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseInvoiceDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseInvoiceDetailsTemp",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    UserID = table.Column<int>(nullable: false),
                    ProductID = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Qty = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Vat = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Description = table.Column<string>(nullable: true),
                    RowPrice = table.Column<decimal>(nullable: true, computedColumnSql: "qty * ((((100-isnull(discount,0)) * isnull(Price,0))/100) + ((isnull(Vat,0) * isnull(Price,0))/100)) ")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseInvoiceDetailsTemp", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseInvoiceType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    Title = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseInvoiceType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SaleInvoice",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    InvoiceNumber = table.Column<string>(maxLength: 150, nullable: true),
                    CustomerID = table.Column<int>(nullable: true),
                    UserID = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    SumPrice = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    SumDiscount = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    SumVat = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    FinalPrice = table.Column<decimal>(nullable: true, computedColumnSql: "(isnull(SumPrice,0) + isnull(SumVat,0)) - isnull(SumDiscount,0) ")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleInvoice", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SaleInvoiceDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    InvoiceID = table.Column<int>(nullable: false),
                    ProductID = table.Column<int>(nullable: false),
                    SalePrice = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    PurchasePrice = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Qty = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Vat = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Description = table.Column<string>(nullable: true),
                    RowPrice = table.Column<decimal>(nullable: true, computedColumnSql: "qty * ((((100-isnull(discount,0)) * isnull(SalePrice,0))/100) + ((isnull(Vat,0) * isnull(SalePrice,0))/100)) ")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleInvoiceDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SaleInvoiceDetailsTemp",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    UserID = table.Column<int>(nullable: false),
                    ProductID = table.Column<int>(nullable: false),
                    SalePrice = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    PurchasePrice = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Qty = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Vat = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Description = table.Column<string>(nullable: true),
                    RowPrice = table.Column<decimal>(nullable: true, computedColumnSql: "qty * ((((100-isnull(discount,0)) * isnull(SalePrice,0))/100) + ((isnull(Vat,0) * isnull(SalePrice,0))/100)) ")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleInvoiceDetailsTemp", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SaleInvoicePayments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    InvoiceID = table.Column<int>(nullable: false),
                    PayTypeID = table.Column<int>(nullable: false),
                    Value = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleInvoicePayments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SaleInvoicePaymentTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    Title = table.Column<string>(maxLength: 150, nullable: true),
                    Description = table.Column<string>(maxLength: 150, nullable: true),
                    IsConnectedToPos = table.Column<bool>(nullable: false),
                    ConnectedPortType = table.Column<string>(maxLength: 150, nullable: true),
                    ConnectedPortNumber = table.Column<string>(maxLength: 150, nullable: true),
                    OnlinePaymentUrl = table.Column<string>(maxLength: 150, nullable: true),
                    OnlinePaymentApi = table.Column<string>(maxLength: 150, nullable: true),
                    OnlinePaymentKey = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleInvoicePaymentTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stock",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    ProductID = table.Column<int>(nullable: false),
                    Qty = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stock", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StockAdjustment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    InvoiceNumber = table.Column<string>(maxLength: 150, nullable: true),
                    InvoiceDate = table.Column<DateTime>(nullable: true),
                    UserID = table.Column<int>(nullable: false),
                    IsOutput = table.Column<bool>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    SumPrice = table.Column<decimal>(type: "decimal(18, 2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockAdjustment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StockAdjustmentDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    InvoiceID = table.Column<int>(nullable: false),
                    ProductID = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Qty = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockAdjustmentDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StockAdjustmentDetailsTemp",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    UserID = table.Column<int>(nullable: false),
                    ProductID = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Qty = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockAdjustmentDetailsTemp", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StockAdjustmentTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    Title = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockAdjustmentTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StockLog",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    ProductID = table.Column<int>(nullable: false),
                    Qty = table.Column<decimal>(nullable: false),
                    TypeID = table.Column<int>(nullable: false),
                    InvoiceNumber = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StockLogType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockLogType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserPermissions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    UserID = table.Column<int>(nullable: false),
                    PermKey = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPermissions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    UserName = table.Column<string>(maxLength: 150, nullable: true),
                    Password = table.Column<string>(maxLength: 150, nullable: true),
                    FirstName = table.Column<string>(maxLength: 150, nullable: true),
                    LastName = table.Column<string>(maxLength: 150, nullable: true),
                    Mobile = table.Column<string>(maxLength: 150, nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Email = table.Column<string>(maxLength: 150, nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IsAdmin = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "GlobalSetting",
                columns: new[] { "Id", "CreateDate", "IsActive", "ProductBarcodeCounter", "PurchaseInvoiceCounter", "SaleInvoiceCounter", "SelectedLanguage", "StockAdjustmentInvoiceCounter" },
                values: new object[] { 1, new DateTime(2019, 3, 25, 19, 23, 31, 525, DateTimeKind.Local).AddTicks(5720), true, 1L, 1L, 1L, null, 1L });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "CreateDate", "IsActive", "PermKey" },
                values: new object[] { 1, new DateTime(2019, 3, 25, 19, 23, 31, 552, DateTimeKind.Local).AddTicks(4782), true, "UserModule" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "CreateDate", "IsActive", "PermKey" },
                values: new object[] { 2, new DateTime(2019, 3, 25, 19, 23, 31, 552, DateTimeKind.Local).AddTicks(5775), true, "ProductModule" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "CreateDate", "IsActive", "PermKey" },
                values: new object[] { 3, new DateTime(2019, 3, 25, 19, 23, 31, 552, DateTimeKind.Local).AddTicks(5802), true, "StockModule" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "CreateDate", "IsActive", "PermKey" },
                values: new object[] { 4, new DateTime(2019, 3, 25, 19, 23, 31, 552, DateTimeKind.Local).AddTicks(5807), true, "SaleModule" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "CreateDate", "IsActive", "PermKey" },
                values: new object[] { 5, new DateTime(2019, 3, 25, 19, 23, 31, 552, DateTimeKind.Local).AddTicks(5810), true, "PurchaseModule" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "CreateDate", "IsActive", "PermKey" },
                values: new object[] { 6, new DateTime(2019, 3, 25, 19, 23, 31, 552, DateTimeKind.Local).AddTicks(5814), true, "CustomerModule" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "CreateDate", "IsActive", "PermKey" },
                values: new object[] { 7, new DateTime(2019, 3, 25, 19, 23, 31, 552, DateTimeKind.Local).AddTicks(5819), true, "StockAdjustmentModule" });

            migrationBuilder.InsertData(
                table: "PurchaseInvoiceType",
                columns: new[] { "Id", "CreateDate", "IsActive", "Title" },
                values: new object[] { 2, new DateTime(2019, 3, 25, 19, 23, 31, 553, DateTimeKind.Local).AddTicks(2192), true, "PurchaseReturn" });

            migrationBuilder.InsertData(
                table: "PurchaseInvoiceType",
                columns: new[] { "Id", "CreateDate", "IsActive", "Title" },
                values: new object[] { 1, new DateTime(2019, 3, 25, 19, 23, 31, 553, DateTimeKind.Local).AddTicks(1438), true, "Purchase" });

            migrationBuilder.InsertData(
                table: "SaleInvoicePaymentTypes",
                columns: new[] { "Id", "ConnectedPortNumber", "ConnectedPortType", "CreateDate", "Description", "IsActive", "IsConnectedToPos", "OnlinePaymentApi", "OnlinePaymentKey", "OnlinePaymentUrl", "Title" },
                values: new object[] { 1, null, null, new DateTime(2019, 3, 25, 19, 23, 31, 552, DateTimeKind.Local).AddTicks(9261), null, true, false, null, null, null, "Cash" });

            migrationBuilder.InsertData(
                table: "SaleInvoicePaymentTypes",
                columns: new[] { "Id", "ConnectedPortNumber", "ConnectedPortType", "CreateDate", "Description", "IsActive", "IsConnectedToPos", "OnlinePaymentApi", "OnlinePaymentKey", "OnlinePaymentUrl", "Title" },
                values: new object[] { 2, null, null, new DateTime(2019, 3, 25, 19, 23, 31, 553, DateTimeKind.Local).AddTicks(312), null, true, false, null, null, null, "BankPOS" });

            migrationBuilder.InsertData(
                table: "StockAdjustmentTypes",
                columns: new[] { "Id", "CreateDate", "IsActive", "Title" },
                values: new object[] { 1, new DateTime(2019, 3, 25, 19, 23, 31, 553, DateTimeKind.Local).AddTicks(3157), true, "Periodic Counting" });

            migrationBuilder.InsertData(
                table: "StockAdjustmentTypes",
                columns: new[] { "Id", "CreateDate", "IsActive", "Title" },
                values: new object[] { 2, new DateTime(2019, 3, 25, 19, 23, 31, 553, DateTimeKind.Local).AddTicks(3820), true, "Waste Products" });

            migrationBuilder.InsertData(
                table: "StockAdjustmentTypes",
                columns: new[] { "Id", "CreateDate", "IsActive", "Title" },
                values: new object[] { 3, new DateTime(2019, 3, 25, 19, 23, 31, 553, DateTimeKind.Local).AddTicks(3841), true, "Management Consumption" });

            migrationBuilder.InsertData(
                table: "StockAdjustmentTypes",
                columns: new[] { "Id", "CreateDate", "IsActive", "Title" },
                values: new object[] { 4, new DateTime(2019, 3, 25, 19, 23, 31, 553, DateTimeKind.Local).AddTicks(3845), true, "Test Usage of Product" });

            migrationBuilder.InsertData(
                table: "StockLogType",
                columns: new[] { "Id", "CreateDate", "IsActive", "Title" },
                values: new object[] { 3, new DateTime(2019, 3, 25, 19, 23, 31, 552, DateTimeKind.Local).AddTicks(7785), true, "StockAdjustment" });

            migrationBuilder.InsertData(
                table: "StockLogType",
                columns: new[] { "Id", "CreateDate", "IsActive", "Title" },
                values: new object[] { 1, new DateTime(2019, 3, 25, 19, 23, 31, 552, DateTimeKind.Local).AddTicks(7039), true, "PurchaseInvoice" });

            migrationBuilder.InsertData(
                table: "StockLogType",
                columns: new[] { "Id", "CreateDate", "IsActive", "Title" },
                values: new object[] { 2, new DateTime(2019, 3, 25, 19, 23, 31, 552, DateTimeKind.Local).AddTicks(7751), true, "SaleInvoice" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CreateDate", "Description", "Email", "FirstName", "IsActive", "IsAdmin", "LastName", "Mobile", "Password", "UserName" },
                values: new object[] { 1, null, new DateTime(2019, 3, 25, 19, 23, 31, 553, DateTimeKind.Local).AddTicks(4677), "Default admin User, password and other properties would be changed later", null, null, true, true, null, null, @"�3�*�H��f�
�5�M��", "admin" });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_Mobile",
                table: "Customers",
                column: "Mobile",
                unique: true,
                filter: "[Mobile] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Permissions_PermKey",
                table: "Permissions",
                column: "PermKey",
                unique: true,
                filter: "[PermKey] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Products_Barcode",
                table: "Products",
                column: "Barcode",
                unique: true,
                filter: "[Barcode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseInvoice_InvoiceNumber",
                table: "PurchaseInvoice",
                column: "InvoiceNumber",
                unique: true,
                filter: "[InvoiceNumber] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_SaleInvoice_InvoiceNumber",
                table: "SaleInvoice",
                column: "InvoiceNumber",
                unique: true,
                filter: "[InvoiceNumber] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_StockAdjustment_InvoiceNumber",
                table: "StockAdjustment",
                column: "InvoiceNumber",
                unique: true,
                filter: "[InvoiceNumber] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Mobile",
                table: "Users",
                column: "Mobile",
                unique: true,
                filter: "[Mobile] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserName",
                table: "Users",
                column: "UserName",
                unique: true,
                filter: "[UserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "GlobalSetting");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ProductsBrand");

            migrationBuilder.DropTable(
                name: "ProductsCategory");

            migrationBuilder.DropTable(
                name: "ProductsProvider");

            migrationBuilder.DropTable(
                name: "PurchaseInvoice");

            migrationBuilder.DropTable(
                name: "PurchaseInvoiceDetails");

            migrationBuilder.DropTable(
                name: "PurchaseInvoiceDetailsTemp");

            migrationBuilder.DropTable(
                name: "PurchaseInvoiceType");

            migrationBuilder.DropTable(
                name: "SaleInvoice");

            migrationBuilder.DropTable(
                name: "SaleInvoiceDetails");

            migrationBuilder.DropTable(
                name: "SaleInvoiceDetailsTemp");

            migrationBuilder.DropTable(
                name: "SaleInvoicePayments");

            migrationBuilder.DropTable(
                name: "SaleInvoicePaymentTypes");

            migrationBuilder.DropTable(
                name: "Stock");

            migrationBuilder.DropTable(
                name: "StockAdjustment");

            migrationBuilder.DropTable(
                name: "StockAdjustmentDetails");

            migrationBuilder.DropTable(
                name: "StockAdjustmentDetailsTemp");

            migrationBuilder.DropTable(
                name: "StockAdjustmentTypes");

            migrationBuilder.DropTable(
                name: "StockLog");

            migrationBuilder.DropTable(
                name: "StockLogType");

            migrationBuilder.DropTable(
                name: "UserPermissions");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
