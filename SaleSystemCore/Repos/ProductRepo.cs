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
    public class ProductRepo : RepoBase<Product>
    {
        public ProductRepo(DbContextOptions<CoreContext> options)
            : base(options)
        { }
        public ProductRepo()
        { }

        public override IEnumerable<Product> GetAll()
            => Table.AsNoTracking().Where(l => !l.IsDeleted).OrderBy(x => x.Name);
        public override IEnumerable<Product> GetRange(int skip, int take)
            => GetRange(Table.AsNoTracking().Where(l => !l.IsDeleted).OrderBy(x => x.Name), skip, take);
    }
}
