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
    public class PurchaseInvoiceRepo : RepoBase<PurchaseInvoices>
    {
        public PurchaseInvoiceRepo(DbContextOptions<CoreContext> options)
            : base(options)
        { }
        public PurchaseInvoiceRepo()
        { }

        public override IEnumerable<PurchaseInvoices> GetAll()
            => Table.OrderBy(x => x.InvoiceNumber);
        public override IEnumerable<PurchaseInvoices> GetRange(int skip, int take)
            => GetRange(Table.OrderBy(x => x.InvoiceNumber), skip, take);
    }
}
