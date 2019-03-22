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
    public class StockAdjustmentRepo : RepoBase<StockAdjustment>
    {
        public StockAdjustmentRepo(DbContextOptions<CoreContext> options)
            : base(options)
        { }
        public StockAdjustmentRepo()
        { }

        public override IEnumerable<StockAdjustment> GetAll()
            => Table.AsNoTracking().OrderBy(x => x.Id);
        public override IEnumerable<StockAdjustment> GetRange(int skip, int take)
            => GetRange(Table.AsNoTracking().OrderBy(x => x.Id), skip, take);
    }
}
    