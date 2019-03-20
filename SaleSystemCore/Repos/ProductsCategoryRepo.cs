using SaleSystemCore.Repos.Base;
using SaleSystemCore.Models;
using Microsoft.EntityFrameworkCore;
using SaleSystemCore.EF;
using System.Linq;
using System.Collections.Generic;

namespace SaleSystemCore.Repos
{
    public class ProductsCategoryRepo : RepoBase<ProductsCategory>
    {
        public ProductsCategoryRepo(DbContextOptions<CoreContext> options)
            : base(options)
        { }
        public ProductsCategoryRepo()
        { }

        public override IEnumerable<ProductsCategory> GetAll()
            => Table.AsNoTracking().OrderBy(x => x.Title);
        public override IEnumerable<ProductsCategory> GetRange(int skip, int take)
            => GetRange(Table.AsNoTracking().OrderBy(x => x.Title), skip, take);
    }   
}