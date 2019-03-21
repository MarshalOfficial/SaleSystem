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
    public class PurchaseInvoiceRepo : RepoBase<PurchaseInvoice>
    {
        public PurchaseInvoiceRepo(DbContextOptions<CoreContext> options)
            : base(options)
        { }
        public PurchaseInvoiceRepo()
        { }

        public override IEnumerable<PurchaseInvoice> GetAll()
            => Table.AsNoTracking().OrderBy(x => x.Id);
        public override IEnumerable<PurchaseInvoice> GetRange(int skip, int take)
            => GetRange(Table.AsNoTracking().OrderBy(x => x.Id), skip, take);
    }
}
