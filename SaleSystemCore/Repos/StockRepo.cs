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
    public class StockRepo : RepoBase<Stock>
    {
        public StockRepo(DbContextOptions<CoreContext> options)
            : base(options)
        { }
        public StockRepo()
        { }

        public override IEnumerable<Stock> GetAll()
            => Table.AsNoTracking().OrderBy(x => x.ProductID);
        public override IEnumerable<Stock> GetRange(int skip, int take)
            => GetRange(Table.AsNoTracking().OrderBy(x => x.ProductID), skip, take);
    }
}
