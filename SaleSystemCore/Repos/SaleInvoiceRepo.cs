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
    public class SaleInvoiceRepo : RepoBase<SaleInvoice>
    {
        public SaleInvoiceRepo(DbContextOptions<CoreContext> options)
            : base(options)
        { }
        public SaleInvoiceRepo()
        { }

        public override IEnumerable<SaleInvoice> GetAll()
            => Table.AsNoTracking().OrderBy(x => x.InvoiceNumber);
        public override IEnumerable<SaleInvoice> GetRange(int skip, int take)
            => GetRange(Table.AsNoTracking().OrderBy(x => x.InvoiceNumber), skip, take);
    }
}
