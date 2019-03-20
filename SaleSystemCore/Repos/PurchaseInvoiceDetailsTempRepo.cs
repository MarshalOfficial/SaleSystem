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
    public class PurchaseInvoiceDetailsTempRepo : RepoBase<PurchaseInvoiceDetailsTemp>
    {
        public PurchaseInvoiceDetailsTempRepo(DbContextOptions<CoreContext> options)
            : base(options)
        { }
        public PurchaseInvoiceDetailsTempRepo()
        { }

        public override IEnumerable<PurchaseInvoiceDetailsTemp> GetAll()
            => Table.AsNoTracking().OrderBy(x => x.UserID);
        public override IEnumerable<PurchaseInvoiceDetailsTemp> GetRange(int skip, int take)
            => GetRange(Table.AsNoTracking().OrderBy(x => x.UserID), skip, take);
    }
}
