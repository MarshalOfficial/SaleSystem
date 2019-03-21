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

        public void SetProductStock(int productid)
        {
            var stock = new StockLogRepo().GetStockByProductID(productid);
            if (stock == null)
            {
                stock = 0;
            }
            var item = Table.AsNoTracking().FirstOrDefault(l => l.ProductID == productid);
            if (item == null)
            {
                Add(new Stock() {ProductID = productid, Qty = stock.Value});
            }
            else
            {
                item.Qty = stock.Value;
                Update(item);
            }
        }
    }
}
