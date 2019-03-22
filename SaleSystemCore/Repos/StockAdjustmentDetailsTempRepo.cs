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
    public class StockAdjustmentDetailsTempRepo : RepoBase<StockAdjustmentDetailsTemp>
    {
        public StockAdjustmentDetailsTempRepo(DbContextOptions<CoreContext> options)
            : base(options)
        { }
        public StockAdjustmentDetailsTempRepo()
        { }


        public IEnumerable<StockAdjustmentDetailsTemp> GetAllByUserID(int userid)
            => Table.Where(l => l.UserID == userid).ToList();
    }
}
