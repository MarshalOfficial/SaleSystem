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
    public class StockLogRepo : RepoBase<StockLog>
    {
        public StockLogRepo(DbContextOptions<CoreContext> options)
            : base(options)
        {
        }

        public StockLogRepo()
        {
        }

        public override IEnumerable<StockLog> GetAll()
            => Table.AsNoTracking().OrderBy(x => x.CreateDate);

        public override IEnumerable<StockLog> GetRange(int skip, int take)
            => GetRange(Table.AsNoTracking().OrderBy(x => x.CreateDate), skip, take);

        public decimal? GetStockByProductID(int productid)
            => Table.AsNoTracking().Where(l => l.ProductID == productid).Sum(j => j.Qty);
    }
}   