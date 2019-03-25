using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using SaleSystemCore.Models;
using SaleSystemCore.Extension;

namespace SaleSystemCore.EF
{
    public class CoreContext : DbContext
    {
        public CoreContext()
        {

        }

        public CoreContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    @"Server=.\sql2017express;Database=SaleStorage;Trusted_Connection=True;MultipleActiveResultSets=true;",
                    options => options.EnableRetryOnFailure());

                //connection string with username password for production server :
                //Server = myServerAddress; Database = myDataBase; User Id = myUsername; Password = myPassword;

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(p => p.ProfitMarkup)
                .HasComputedColumnSql("((isnull(SalePrice,0) - isnull(PurchasePrice,0))/isnull(PurchasePrice,0))*100");
            modelBuilder.Entity<Product>()
                .Property(p => p.ProfitMargin)
                .HasComputedColumnSql("((isnull(SalePrice,0) - isnull(PurchasePrice,0))/isnull(SalePrice,0))*100");


            modelBuilder.Entity<SaleInvoice>()
                .Property(p => p.FinalPrice)
                .HasComputedColumnSql("(isnull(SumPrice,0) + isnull(SumVat,0)) - isnull(SumDiscount,0) ");

            modelBuilder.Entity<PurchaseInvoice>()
                .Property(p => p.FinalPrice)
                .HasComputedColumnSql("(isnull(SumPrice,0) + isnull(SumVat,0)) - isnull(SumDiscount,0) ");

            modelBuilder.Entity<SaleInvoiceDetailsTemp>()
                .Property(p => p.RowPrice)
                .HasComputedColumnSql("qty * ((((100-isnull(discount,0)) * isnull(SalePrice,0))/100) + ((isnull(Vat,0) * isnull(SalePrice,0))/100)) ");

            modelBuilder.Entity<SaleInvoiceDetails>()
                .Property(p => p.RowPrice)
                .HasComputedColumnSql("qty * ((((100-isnull(discount,0)) * isnull(SalePrice,0))/100) + ((isnull(Vat,0) * isnull(SalePrice,0))/100)) ");

            modelBuilder.Entity<PurchaseInvoiceDetailsTemp>()
                .Property(p => p.RowPrice)
                .HasComputedColumnSql("qty * ((((100-isnull(discount,0)) * isnull(Price,0))/100) + ((isnull(Vat,0) * isnull(Price,0))/100)) ");

            modelBuilder.Entity<PurchaseInvoiceDetails>()
                .Property(p => p.RowPrice)
                .HasComputedColumnSql("qty * ((((100-isnull(discount,0)) * isnull(Price,0))/100) + ((isnull(Vat,0) * isnull(Price,0))/100)) ");


            modelBuilder.Entity<GlobalSetting>().HasData(new GlobalSetting
            {
                Id = 1,
                SaleInvoiceCounter = 1,
                PurchaseInvoiceCounter = 1,
                ProductBarcodeCounter = 1,
                StockAdjustmentInvoiceCounter = 1
            });

            modelBuilder.Entity<User>().HasIndex(u => u.UserName).IsUnique();
            modelBuilder.Entity<User>().HasIndex(u => u.Mobile).IsUnique();
            modelBuilder.Entity<Customer>().HasIndex(u => u.Mobile).IsUnique();
            modelBuilder.Entity<Product>().HasIndex(u => u.Barcode).IsUnique();
            modelBuilder.Entity<Permission>().HasIndex(u => u.PermKey).IsUnique();
            modelBuilder.Entity<SaleInvoice>().HasIndex(u => u.InvoiceNumber).IsUnique();
            modelBuilder.Entity<PurchaseInvoice>().HasIndex(u => u.InvoiceNumber).IsUnique();
            modelBuilder.Entity<StockAdjustment>().HasIndex(u => u.InvoiceNumber).IsUnique();

            modelBuilder.Entity<Permission>().HasData(new Permission[]
            {
                new Permission() {Id = 1, PermKey = "UserModule"},
                new Permission() {Id = 2, PermKey = "ProductModule"},
                new Permission() {Id = 3, PermKey = "StockModule"},
                new Permission() {Id = 4, PermKey = "SaleModule"},
                new Permission() {Id = 5, PermKey = "PurchaseModule"},
                new Permission() {Id = 6, PermKey = "CustomerModule"},
                new Permission() {Id = 7, PermKey = "StockAdjustmentModule"}
            });

            modelBuilder.Entity<StockLogType>().HasData(new StockLogType[]
            {
                new StockLogType() {Id = 1, Title = "PurchaseInvoice"},
                new StockLogType() {Id = 2, Title = "SaleInvoice"},
                new StockLogType() {Id = 3, Title = "StockAdjustment"}  
            });


            modelBuilder.Entity<SaleInvoicePaymentTypes>().HasData(new SaleInvoicePaymentTypes[]
            {
                new SaleInvoicePaymentTypes() {Id = 1, Title = "Cash"},
                new SaleInvoicePaymentTypes() {Id = 2, Title = "BankPOS"}
            });

            modelBuilder.Entity<PurchaseInvoiceType>().HasData(new PurchaseInvoiceType[]
            {
                new PurchaseInvoiceType() {Id = 1, Title = "Purchase"},
                new PurchaseInvoiceType() {Id = 2, Title = "PurchaseReturn"}    
            });

            modelBuilder.Entity<StockAdjustmentTypes>().HasData(new StockAdjustmentTypes[]
            {
                new StockAdjustmentTypes() {Id = 1, Title = "Periodic Counting"},
                new StockAdjustmentTypes() {Id = 2, Title = "Waste Products"},
                new StockAdjustmentTypes() {Id = 3, Title = "Management Consumption"},
                new StockAdjustmentTypes() {Id = 4, Title = "Test Usage of Product"},
            });

            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 1,
                UserName = "admin",
                Password = "admin".HashString(),
                Description = "Default admin User, password and other properties would be changed later",
                IsAdmin = true
            });
        }

        public DbSet<ProductsCategory> ProductsCategories { get; set; }
        public DbSet<ProductsBrand> ProductsBrands { get; set; }
        public DbSet<ProductsProvider> ProductsProviders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<PurchaseInvoice> PurchaseInvoices { get; set; }
        public DbSet<PurchaseInvoiceDetails> PurchaseInvoiceDetails { get; set; }
        public DbSet<PurchaseInvoiceDetailsTemp> PurchaseInvoiceDetailsTemps { get; set; }
        public DbSet<SaleInvoice> SaleInvoices { get; set; }
        public DbSet<SaleInvoiceDetails> SaleInvoiceDetails { get; set; }
        public DbSet<SaleInvoiceDetailsTemp> SaleInvoiceDetailsTemps { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<StockLog> StockLogs { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<GlobalSetting> GlobalSetting { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<UserPermissions> UserPermissions { get; set; }
        public DbSet<StockLogType> StockLogTypes { get; set; }
        public DbSet<SaleInvoicePayments> SaleInvoicePayments { get; set; }
        public DbSet<SaleInvoicePaymentTypes> SaleInvoicePaymentTypes { get; set; }
        public DbSet<PurchaseInvoiceType> PurchaseInvoiceTypes { get; set; }
        public DbSet<StockAdjustment> StockAdjustment { get; set; }
        public DbSet<StockAdjustmentDetails> StockAdjustmentDetails { get; set; }
        public DbSet<StockAdjustmentDetailsTemp> StockAdjustmentDetailsTemp { get; set; }
        public DbSet<StockAdjustmentTypes> StockAdjustmentTypes { get; set; }

    }
}