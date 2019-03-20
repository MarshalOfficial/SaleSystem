using SaleSystemCore.Repos.Base;
using System;
using System.Collections.Generic;
using System.Text;
using SaleSystemCore.Models;
using Microsoft.EntityFrameworkCore;
using SaleSystemCore.EF;
using System.Linq;

namespace SaleSystemCore.Repos
{
    public class ProductsBrandRepo : RepoBase<ProductsBrand>
    {
        public ProductsBrandRepo(DbContextOptions<CoreContext> options)
            : base(options)
        { }
        public ProductsBrandRepo()
        { }

        public override IEnumerable<ProductsBrand> GetAll()
            => Table.AsNoTracking().OrderBy(x => x.Title);
        public override IEnumerable<ProductsBrand> GetRange(int skip, int take)
            => GetRange(Table.AsNoTracking().OrderBy(x => x.Title), skip, take);
    }
}
