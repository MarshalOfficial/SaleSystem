using Microsoft.EntityFrameworkCore;
using SaleSystemCore.EF;
using SaleSystemCore.Models;
using SaleSystemCore.Repos.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SaleSystemCore.Repos
{
    public class StockAdjustmentDetailRepo : RepoBase<StockAdjustmentDetails>
    {
        public StockAdjustmentDetailRepo(DbContextOptions<CoreContext> options)
            : base(options)
        { }
        public StockAdjustmentDetailRepo()
        { }

        public override IEnumerable<StockAdjustmentDetails> GetAll()
            => Table.AsNoTracking().OrderBy(x => x.ProductID);
        public override IEnumerable<StockAdjustmentDetails> GetRange(int skip, int take)
            => GetRange(Table.AsNoTracking().OrderBy(x => x.ProductID), skip, take);



        public IEnumerable<StockAdjustmentDetails> GetAllByInvoiceID(int invid)
            => Table.AsNoTracking().Where(l => l.InvoiceID == invid).OrderBy(x => x.ProductID);
    }
}
