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
    public class SaleInvoiceDetailRepo : RepoBase<SaleInvoiceDetails>
    {
        public SaleInvoiceDetailRepo(DbContextOptions<CoreContext> options)
            : base(options)
        { }
        public SaleInvoiceDetailRepo()
        { }

        public override IEnumerable<SaleInvoiceDetails> GetAll()
            => Table.AsNoTracking().OrderBy(x => x.ProductID);
        public override IEnumerable<SaleInvoiceDetails> GetRange(int skip, int take)
            => GetRange(Table.AsNoTracking().OrderBy(x => x.ProductID), skip, take);
    }
}
