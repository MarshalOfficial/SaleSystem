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
        }

        public DbSet<ProductsCategory> ProductsCategories { get; set; }
        public DbSet<ProductsBrand> ProductsBrands { get; set; }    

    }
}
