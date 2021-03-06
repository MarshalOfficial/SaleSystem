﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SaleSystemCore.EF;

namespace SaleSystemCore.Migrations
{
    [DbContext(typeof(CoreContext))]
    partial class CoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SaleSystemCore.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(1000);

                    b.Property<DateTime?>("BirthDate");

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("Description");

                    b.Property<string>("Email")
                        .HasMaxLength(150);

                    b.Property<string>("FirstName")
                        .HasMaxLength(150);

                    b.Property<string>("Instagram")
                        .HasMaxLength(150);

                    b.Property<bool>("IsActive");

                    b.Property<string>("LastName")
                        .HasMaxLength(150);

                    b.Property<DateTime?>("MarriageDate");

                    b.Property<string>("Mobile")
                        .HasMaxLength(150);

                    b.Property<string>("Tel")
                        .HasMaxLength(150);

                    b.Property<byte[]>("TimeStamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.HasIndex("Mobile")
                        .IsUnique()
                        .HasFilter("[Mobile] IS NOT NULL");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("SaleSystemCore.Models.GlobalSetting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate");

                    b.Property<bool>("IsActive");

                    b.Property<long>("ProductBarcodeCounter");

                    b.Property<long>("PurchaseInvoiceCounter");

                    b.Property<long>("SaleInvoiceCounter");

                    b.Property<string>("SelectedLanguage");

                    b.Property<long>("StockAdjustmentInvoiceCounter");

                    b.Property<byte[]>("TimeStamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.ToTable("GlobalSetting");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDate = new DateTime(2019, 5, 7, 16, 2, 34, 564, DateTimeKind.Local).AddTicks(1476),
                            IsActive = true,
                            ProductBarcodeCounter = 1L,
                            PurchaseInvoiceCounter = 1L,
                            SaleInvoiceCounter = 1L,
                            StockAdjustmentInvoiceCounter = 1L
                        });
                });

            modelBuilder.Entity("SaleSystemCore.Models.Permission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate");

                    b.Property<bool>("IsActive");

                    b.Property<string>("PermKey")
                        .HasMaxLength(150);

                    b.Property<byte[]>("TimeStamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.HasIndex("PermKey")
                        .IsUnique()
                        .HasFilter("[PermKey] IS NOT NULL");

                    b.ToTable("Permissions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDate = new DateTime(2019, 5, 7, 16, 2, 34, 585, DateTimeKind.Local).AddTicks(1159),
                            IsActive = true,
                            PermKey = "UserModule"
                        },
                        new
                        {
                            Id = 2,
                            CreateDate = new DateTime(2019, 5, 7, 16, 2, 34, 585, DateTimeKind.Local).AddTicks(1159),
                            IsActive = true,
                            PermKey = "ProductModule"
                        },
                        new
                        {
                            Id = 3,
                            CreateDate = new DateTime(2019, 5, 7, 16, 2, 34, 585, DateTimeKind.Local).AddTicks(1159),
                            IsActive = true,
                            PermKey = "StockModule"
                        },
                        new
                        {
                            Id = 4,
                            CreateDate = new DateTime(2019, 5, 7, 16, 2, 34, 585, DateTimeKind.Local).AddTicks(1159),
                            IsActive = true,
                            PermKey = "SaleModule"
                        },
                        new
                        {
                            Id = 5,
                            CreateDate = new DateTime(2019, 5, 7, 16, 2, 34, 585, DateTimeKind.Local).AddTicks(1159),
                            IsActive = true,
                            PermKey = "PurchaseModule"
                        },
                        new
                        {
                            Id = 6,
                            CreateDate = new DateTime(2019, 5, 7, 16, 2, 34, 585, DateTimeKind.Local).AddTicks(1159),
                            IsActive = true,
                            PermKey = "CustomerModule"
                        },
                        new
                        {
                            Id = 7,
                            CreateDate = new DateTime(2019, 5, 7, 16, 2, 34, 585, DateTimeKind.Local).AddTicks(1159),
                            IsActive = true,
                            PermKey = "StockAdjustmentModule"
                        });
                });

            modelBuilder.Entity("SaleSystemCore.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Barcode")
                        .HasMaxLength(500);

                    b.Property<int?>("BrandID");

                    b.Property<int?>("CategoryID");

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("Description");

                    b.Property<decimal?>("Discount")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name")
                        .HasMaxLength(250);

                    b.Property<decimal?>("ProfitMargin")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasComputedColumnSql("((isnull(SalePrice,0) - isnull(PurchasePrice,0))/isnull(SalePrice,0))*100");

                    b.Property<decimal?>("ProfitMarkup")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasComputedColumnSql("((isnull(SalePrice,0) - isnull(PurchasePrice,0))/isnull(PurchasePrice,0))*100");

                    b.Property<int?>("ProviderID");

                    b.Property<decimal?>("PurchasePrice")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("SalePrice")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<byte[]>("TimeStamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<decimal?>("Vat")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("Id");

                    b.HasIndex("Barcode")
                        .IsUnique()
                        .HasFilter("[Barcode] IS NOT NULL");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("SaleSystemCore.Models.ProductsBrand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("Description");

                    b.Property<bool>("IsActive");

                    b.Property<byte[]>("TimeStamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("Title")
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.ToTable("ProductsBrand");
                });

            modelBuilder.Entity("SaleSystemCore.Models.ProductsCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate");

                    b.Property<bool>("IsActive");

                    b.Property<byte[]>("TimeStamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("Title")
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.ToTable("ProductsCategory");
                });

            modelBuilder.Entity("SaleSystemCore.Models.ProductsProvider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("BankAccountInfo")
                        .HasMaxLength(150);

                    b.Property<string>("CompnayName")
                        .HasMaxLength(150);

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("Description");

                    b.Property<string>("Email")
                        .HasMaxLength(150);

                    b.Property<bool>("IsActive");

                    b.Property<string>("Mobile")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .HasMaxLength(150);

                    b.Property<string>("NationalCode")
                        .HasMaxLength(150);

                    b.Property<string>("OnlinePaymentUrl")
                        .HasMaxLength(500);

                    b.Property<string>("OnlinePaymentUrlApiKey")
                        .HasMaxLength(1000);

                    b.Property<string>("RegistrationNo")
                        .HasMaxLength(250);

                    b.Property<string>("Tel")
                        .HasMaxLength(100);

                    b.Property<byte[]>("TimeStamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.ToTable("ProductsProvider");
                });

            modelBuilder.Entity("SaleSystemCore.Models.PurchaseInvoice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("Description");

                    b.Property<decimal?>("FinalPrice")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasComputedColumnSql("(isnull(SumPrice,0) + isnull(SumVat,0)) - isnull(SumDiscount,0) ");

                    b.Property<DateTime?>("InvoiceDate");

                    b.Property<string>("InvoiceNumber")
                        .HasMaxLength(150);

                    b.Property<int>("InvoiceType");

                    b.Property<bool>("IsActive");

                    b.Property<int?>("ProviderID");

                    b.Property<decimal?>("SumDiscount")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal?>("SumPrice")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal?>("SumVat")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<byte[]>("TimeStamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("UserID");

                    b.HasKey("Id");

                    b.HasIndex("InvoiceNumber")
                        .IsUnique()
                        .HasFilter("[InvoiceNumber] IS NOT NULL");

                    b.ToTable("PurchaseInvoice");
                });

            modelBuilder.Entity("SaleSystemCore.Models.PurchaseInvoiceDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("Description");

                    b.Property<decimal?>("Discount")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("InvoiceID");

                    b.Property<bool>("IsActive");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("ProductID");

                    b.Property<decimal>("Qty")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal?>("RowPrice")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasComputedColumnSql("qty * ((((100-isnull(discount,0)) * isnull(Price,0))/100) + ((isnull(Vat,0) * isnull(Price,0))/100)) ");

                    b.Property<byte[]>("TimeStamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<decimal?>("Vat")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("Id");

                    b.ToTable("PurchaseInvoiceDetails");
                });

            modelBuilder.Entity("SaleSystemCore.Models.PurchaseInvoiceDetailsTemp", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("Description");

                    b.Property<decimal?>("Discount")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<bool>("IsActive");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("ProductID");

                    b.Property<decimal>("Qty")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal?>("RowPrice")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasComputedColumnSql("qty * ((((100-isnull(discount,0)) * isnull(Price,0))/100) + ((isnull(Vat,0) * isnull(Price,0))/100)) ");

                    b.Property<byte[]>("TimeStamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("UserID");

                    b.Property<decimal?>("Vat")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("Id");

                    b.ToTable("PurchaseInvoiceDetailsTemp");
                });

            modelBuilder.Entity("SaleSystemCore.Models.PurchaseInvoiceType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate");

                    b.Property<bool>("IsActive");

                    b.Property<byte[]>("TimeStamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("Title")
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.ToTable("PurchaseInvoiceType");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDate = new DateTime(2019, 5, 7, 16, 2, 34, 586, DateTimeKind.Local).AddTicks(1153),
                            IsActive = true,
                            Title = "Purchase"
                        },
                        new
                        {
                            Id = 2,
                            CreateDate = new DateTime(2019, 5, 7, 16, 2, 34, 586, DateTimeKind.Local).AddTicks(1153),
                            IsActive = true,
                            Title = "PurchaseReturn"
                        });
                });

            modelBuilder.Entity("SaleSystemCore.Models.SaleInvoice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate");

                    b.Property<int?>("CustomerID");

                    b.Property<string>("Description");

                    b.Property<decimal?>("FinalPrice")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasComputedColumnSql("(isnull(SumPrice,0) + isnull(SumVat,0)) - isnull(SumDiscount,0) ");

                    b.Property<string>("InvoiceNumber")
                        .HasMaxLength(150);

                    b.Property<bool>("IsActive");

                    b.Property<decimal?>("SumDiscount")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal?>("SumPrice")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal?>("SumVat")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<byte[]>("TimeStamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("UserID");

                    b.HasKey("Id");

                    b.HasIndex("InvoiceNumber")
                        .IsUnique()
                        .HasFilter("[InvoiceNumber] IS NOT NULL");

                    b.ToTable("SaleInvoice");
                });

            modelBuilder.Entity("SaleSystemCore.Models.SaleInvoiceDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("Description");

                    b.Property<decimal?>("Discount")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("InvoiceID");

                    b.Property<bool>("IsActive");

                    b.Property<int>("ProductID");

                    b.Property<decimal>("PurchasePrice")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("Qty")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal?>("RowPrice")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasComputedColumnSql("qty * ((((100-isnull(discount,0)) * isnull(SalePrice,0))/100) + ((isnull(Vat,0) * isnull(SalePrice,0))/100)) ");

                    b.Property<decimal>("SalePrice")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<byte[]>("TimeStamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<decimal?>("Vat")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("Id");

                    b.ToTable("SaleInvoiceDetails");
                });

            modelBuilder.Entity("SaleSystemCore.Models.SaleInvoiceDetailsTemp", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("Description");

                    b.Property<decimal?>("Discount")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<bool>("IsActive");

                    b.Property<int>("ProductID");

                    b.Property<decimal>("PurchasePrice")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("Qty")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal?>("RowPrice")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasComputedColumnSql("qty * ((((100-isnull(discount,0)) * isnull(SalePrice,0))/100) + ((isnull(Vat,0) * isnull(SalePrice,0))/100)) ");

                    b.Property<decimal>("SalePrice")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<byte[]>("TimeStamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("UserID");

                    b.Property<decimal?>("Vat")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("Id");

                    b.ToTable("SaleInvoiceDetailsTemp");
                });

            modelBuilder.Entity("SaleSystemCore.Models.SaleInvoicePaymentTypes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConnectedPortNumber")
                        .HasMaxLength(150);

                    b.Property<string>("ConnectedPortType")
                        .HasMaxLength(150);

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("Description")
                        .HasMaxLength(150);

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsConnectedToPos");

                    b.Property<string>("OnlinePaymentApi")
                        .HasMaxLength(150);

                    b.Property<string>("OnlinePaymentKey")
                        .HasMaxLength(150);

                    b.Property<string>("OnlinePaymentUrl")
                        .HasMaxLength(150);

                    b.Property<byte[]>("TimeStamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("Title")
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.ToTable("SaleInvoicePaymentTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDate = new DateTime(2019, 5, 7, 16, 2, 34, 585, DateTimeKind.Local).AddTicks(1159),
                            IsActive = true,
                            IsConnectedToPos = false,
                            Title = "Cash"
                        },
                        new
                        {
                            Id = 2,
                            CreateDate = new DateTime(2019, 5, 7, 16, 2, 34, 586, DateTimeKind.Local).AddTicks(1153),
                            IsActive = true,
                            IsConnectedToPos = false,
                            Title = "BankPOS"
                        });
                });

            modelBuilder.Entity("SaleSystemCore.Models.SaleInvoicePayments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("Description");

                    b.Property<int>("InvoiceID");

                    b.Property<bool>("IsActive");

                    b.Property<int>("PayTypeID");

                    b.Property<byte[]>("TimeStamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<decimal>("Value")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("Id");

                    b.ToTable("SaleInvoicePayments");
                });

            modelBuilder.Entity("SaleSystemCore.Models.Stock", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate");

                    b.Property<bool>("IsActive");

                    b.Property<int>("ProductID");

                    b.Property<decimal>("Qty");

                    b.Property<byte[]>("TimeStamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.ToTable("Stock");
                });

            modelBuilder.Entity("SaleSystemCore.Models.StockAdjustment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("Description");

                    b.Property<DateTime?>("InvoiceDate");

                    b.Property<string>("InvoiceNumber")
                        .HasMaxLength(150);

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsOutput");

                    b.Property<decimal?>("SumPrice")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<byte[]>("TimeStamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("Type");

                    b.Property<int>("UserID");

                    b.HasKey("Id");

                    b.HasIndex("InvoiceNumber")
                        .IsUnique()
                        .HasFilter("[InvoiceNumber] IS NOT NULL");

                    b.ToTable("StockAdjustment");
                });

            modelBuilder.Entity("SaleSystemCore.Models.StockAdjustmentDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("Description");

                    b.Property<int>("InvoiceID");

                    b.Property<bool>("IsActive");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("ProductID");

                    b.Property<decimal>("Qty")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<byte[]>("TimeStamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.ToTable("StockAdjustmentDetails");
                });

            modelBuilder.Entity("SaleSystemCore.Models.StockAdjustmentDetailsTemp", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("Description");

                    b.Property<bool>("IsActive");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("ProductID");

                    b.Property<decimal>("Qty")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<byte[]>("TimeStamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("UserID");

                    b.HasKey("Id");

                    b.ToTable("StockAdjustmentDetailsTemp");
                });

            modelBuilder.Entity("SaleSystemCore.Models.StockAdjustmentTypes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate");

                    b.Property<bool>("IsActive");

                    b.Property<byte[]>("TimeStamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("Title")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("StockAdjustmentTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDate = new DateTime(2019, 5, 7, 16, 2, 34, 586, DateTimeKind.Local).AddTicks(1153),
                            IsActive = true,
                            Title = "Periodic Counting"
                        },
                        new
                        {
                            Id = 2,
                            CreateDate = new DateTime(2019, 5, 7, 16, 2, 34, 586, DateTimeKind.Local).AddTicks(1153),
                            IsActive = true,
                            Title = "Waste Products"
                        },
                        new
                        {
                            Id = 3,
                            CreateDate = new DateTime(2019, 5, 7, 16, 2, 34, 586, DateTimeKind.Local).AddTicks(1153),
                            IsActive = true,
                            Title = "Management Consumption"
                        },
                        new
                        {
                            Id = 4,
                            CreateDate = new DateTime(2019, 5, 7, 16, 2, 34, 586, DateTimeKind.Local).AddTicks(1153),
                            IsActive = true,
                            Title = "Test Usage of Product"
                        });
                });

            modelBuilder.Entity("SaleSystemCore.Models.StockLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("InvoiceNumber")
                        .HasMaxLength(150);

                    b.Property<bool>("IsActive");

                    b.Property<int>("ProductID");

                    b.Property<decimal>("Qty");

                    b.Property<byte[]>("TimeStamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("TypeID");

                    b.HasKey("Id");

                    b.ToTable("StockLog");
                });

            modelBuilder.Entity("SaleSystemCore.Models.StockLogType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate");

                    b.Property<bool>("IsActive");

                    b.Property<byte[]>("TimeStamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("StockLogType");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDate = new DateTime(2019, 5, 7, 16, 2, 34, 585, DateTimeKind.Local).AddTicks(1159),
                            IsActive = true,
                            Title = "PurchaseInvoice"
                        },
                        new
                        {
                            Id = 2,
                            CreateDate = new DateTime(2019, 5, 7, 16, 2, 34, 585, DateTimeKind.Local).AddTicks(1159),
                            IsActive = true,
                            Title = "SaleInvoice"
                        },
                        new
                        {
                            Id = 3,
                            CreateDate = new DateTime(2019, 5, 7, 16, 2, 34, 585, DateTimeKind.Local).AddTicks(1159),
                            IsActive = true,
                            Title = "StockAdjustment"
                        });
                });

            modelBuilder.Entity("SaleSystemCore.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("Description");

                    b.Property<string>("Email")
                        .HasMaxLength(150);

                    b.Property<string>("FirstName")
                        .HasMaxLength(150);

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsAdmin");

                    b.Property<string>("LastName")
                        .HasMaxLength(150);

                    b.Property<string>("Mobile")
                        .HasMaxLength(150);

                    b.Property<string>("Password")
                        .HasMaxLength(150);

                    b.Property<byte[]>("TimeStamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("UserName")
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.HasIndex("Mobile")
                        .IsUnique()
                        .HasFilter("[Mobile] IS NOT NULL");

                    b.HasIndex("UserName")
                        .IsUnique()
                        .HasFilter("[UserName] IS NOT NULL");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDate = new DateTime(2019, 5, 7, 16, 2, 34, 586, DateTimeKind.Local).AddTicks(1153),
                            Description = "Default admin User, password and other properties would be changed later",
                            IsActive = true,
                            IsAdmin = true,
                            Password = @"�3�*�H��f�
�5�M��",
                            UserName = "admin"
                        });
                });

            modelBuilder.Entity("SaleSystemCore.Models.UserPermissions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate");

                    b.Property<bool>("IsActive");

                    b.Property<string>("PermKey")
                        .HasMaxLength(150);

                    b.Property<byte[]>("TimeStamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("UserID");

                    b.HasKey("Id");

                    b.ToTable("UserPermissions");
                });
#pragma warning restore 612, 618
        }
    }
}
