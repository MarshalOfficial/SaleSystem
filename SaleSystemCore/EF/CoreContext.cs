using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using SaleSystemCore.Models;

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
        }

        public DbSet<ProductsCategory> ProductsCategories { get; set; }
        public DbSet<ProductsBrand> ProductsBrands { get; set; }
        public DbSet<ProductsProvider> ProductsProviders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<PurchaseInvoice> PurchaseInvoice { get; set; }
        public DbSet<PurchaseInvoiceDetails> PurchaseInvoiceDetails { get; set; }
        public DbSet<PurchaseInvoiceDetailsTemp> PurchaseInvoiceDetailsTemps { get; set; }
        public DbSet<SaleInvoice> SaleInvoice { get; set; }
        public DbSet<SaleInvoiceDetails> SaleInvoiceDetails { get; set; }
        public DbSet<SaleInvoiceDetailsTemp> SaleInvoiceDetailsTemps { get; set; }

    }
}