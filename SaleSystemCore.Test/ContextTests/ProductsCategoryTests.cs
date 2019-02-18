using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using SaleSystemCore.EF;
using SaleSystemCore.Models;
using Xunit;

namespace SaleSystemCore.Test.ContextTests
{
    [Collection("SaleSystemCore")]
    public class ProductsCategoryTests : IDisposable
    {
        private readonly CoreContext _db;
        public ProductsCategoryTests()
        {
            _db = new CoreContext();
            CleanDatabase();
        }

        public void Dispose()
        {
            CleanDatabase();
            _db.Dispose();
        }

        private void CleanDatabase()
        {
            _db.Database.ExecuteSqlCommand("Delete from ProductsCategory");
            _db.Database.ExecuteSqlCommand($"DBCC CHECKIDENT (\"ProductsCategory\", RESEED, -1);");
        }


        [Fact]
        public void FirstTest()
        {
            Assert.True(true);
        }

        [Fact]
        public void ShouldAddACategoryWithDbSet()
        {
            var category = new ProductsCategory { Title = "Foo" };
            _db.ProductsCategories.Add(category);
            Assert.Equal(EntityState.Added, _db.Entry(category).State);
            Assert.True(category.Id < 0);
            Assert.Null(category.TimeStamp);
            _db.SaveChanges();
            Assert.Equal(EntityState.Unchanged, _db.Entry(category).State);
            Assert.Equal(0, category.Id);
            Assert.NotNull(category.TimeStamp);
            Assert.Equal(1, _db.ProductsCategories.Count());
        }

        [Fact]
        public void ShouldAddACategoryWithContext()
        {
            var category = new ProductsCategory { Title = "Foo" };
            _db.Add(category);
            Assert.Equal(EntityState.Added, _db.Entry(category).State);
            Assert.True(category.Id < 0);
            Assert.Null(category.TimeStamp);
            _db.SaveChanges();
            Assert.Equal(EntityState.Unchanged, _db.Entry(category).State);
            Assert.Equal(0, category.Id);
            Assert.NotNull(category.TimeStamp);
            Assert.Equal(1, _db.ProductsCategories.Count());
        }

        [Fact]
        public void ShouldGetAllCategoriesOrderedByName()
        {
            _db.ProductsCategories.Add(new ProductsCategory { Title = "Foo" });
            _db.ProductsCategories.Add(new ProductsCategory { Title = "Bar" });
            _db.SaveChanges();
            var categories = _db.ProductsCategories.OrderBy(c => c.Title).ToList();
            Assert.Equal(2, _db.ProductsCategories.Count());
            Assert.Equal("Bar", categories[0].Title);
            Assert.Equal("Foo", categories[1].Title);
        }

        [Fact]
        public void ShouldUpdateACategory()
        {
            var category = new ProductsCategory { Title = "Foo" };
            _db.ProductsCategories.Add(category);
            _db.SaveChanges();
            category.Title = "Bar";
            _db.ProductsCategories.Update(category);
            Assert.Equal(EntityState.Modified, _db.Entry(category).State);
            _db.SaveChanges();
            Assert.Equal(EntityState.Unchanged, _db.Entry(category).State);
            CoreContext context;
            using (context = new CoreContext())
            {
                Assert.Equal("Bar", context.ProductsCategories.First().Title);
            }
        }

        [Fact]
        public void ShouldNotUpdateANonAttachedCategory()
        {
            var category = new ProductsCategory { Title = "Foo" };
            _db.ProductsCategories.Add(category);
            category.Title = "Bar";
            Assert.Throws<InvalidOperationException>(() => _db.ProductsCategories.Update(category));
        }

        [Fact]
        public void ShouldDeleteACategory()
        {
            var category = new ProductsCategory { Title = "Foo" };
            _db.ProductsCategories.Add(category);
            _db.SaveChanges();
            Assert.Equal(1, _db.ProductsCategories.Count());
            _db.ProductsCategories.Remove(category);
            Assert.Equal(EntityState.Deleted, _db.Entry(category).State);
            _db.SaveChanges();
            Assert.Equal(EntityState.Detached, _db.Entry(category).State);
            Assert.Equal(0, _db.ProductsCategories.Count());
        }

        [Fact]
        public void ShouldDeleteACategoryWithTimestampData()
        {
            var category = new ProductsCategory { Title = "Foo" };
            _db.ProductsCategories.Add(category);
            _db.SaveChanges();
            var context = new CoreContext();
            var catToDelete = new ProductsCategory { Id = category.Id, TimeStamp = category.TimeStamp };
            context.Entry(catToDelete).State = EntityState.Deleted;
            var affected = context.SaveChanges();
            Assert.Equal(1, affected);
        }

        [Fact]
        public void ShouldNotDeleteACategoryWithoutTimestampData()
        {
            var category = new ProductsCategory { Title = "Foo" };
            _db.ProductsCategories.Add(category);
            _db.SaveChanges();
            var context = new CoreContext();
            var catToDelete = new ProductsCategory { Id = category.Id };
            context.ProductsCategories.Remove(catToDelete);
            var ex = Assert.Throws<DbUpdateConcurrencyException>(() => context.SaveChanges());
            Assert.Equal(1, ex.Entries.Count);
            Assert.Equal(category.Id, ((ProductsCategory)ex.Entries[0].Entity).Id);
        }


    }
}
