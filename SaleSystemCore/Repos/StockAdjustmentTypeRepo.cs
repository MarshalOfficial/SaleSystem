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
    public class StockAdjustmentTypeRepo : RepoBase<StockAdjustmentTypes>
    {
        public StockAdjustmentTypeRepo(DbContextOptions<CoreContext> options)
            : base(options)
        {
        }

        public StockAdjustmentTypeRepo()
        {
        }

        public override IEnumerable<StockAdjustmentTypes> GetAll()
            => Table.AsNoTracking().OrderBy(x => x.Id);

        public override IEnumerable<StockAdjustmentTypes> GetRange(int skip, int take)
            => GetRange(Table.AsNoTracking().OrderBy(x => x.Id), skip, take);
    }
}