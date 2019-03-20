using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using SaleSystemCore.EF;
using SaleSystemCore.Models;
using SaleSystemCore.Repos.Base;

namespace SaleSystemCore.Repos
{
    public class ProductsProviderRepo : RepoBase<ProductsProvider>
    {
        public ProductsProviderRepo(DbContextOptions<CoreContext> options)
            : base(options)
        { }
        public ProductsProviderRepo()
        { } 

        public override IEnumerable<ProductsProvider> GetAll()
            => Table.AsNoTracking().OrderBy(x => x.Name);
        public override IEnumerable<ProductsProvider> GetRange(int skip, int take)
            => GetRange(Table.AsNoTracking().OrderBy(x => x.Name), skip, take);
    }
}
    