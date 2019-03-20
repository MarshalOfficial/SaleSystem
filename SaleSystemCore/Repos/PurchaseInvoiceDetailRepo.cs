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
    public class PurchaseInvoiceDetailRepo : RepoBase<PurchaseInvoiceDetails>
    {
        public PurchaseInvoiceDetailRepo(DbContextOptions<CoreContext> options)
            : base(options)
        { }
        public PurchaseInvoiceDetailRepo()
        { }

        public override IEnumerable<PurchaseInvoiceDetails> GetAll()
            => Table.AsNoTracking().OrderBy(x => x.ProductID);
        public override IEnumerable<PurchaseInvoiceDetails> GetRange(int skip, int take)
            => GetRange(Table.AsNoTracking().OrderBy(x => x.ProductID), skip, take);
    }
}
