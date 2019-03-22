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
    public class SaleInvoicePaymentRepo : RepoBase<SaleInvoicePayments>
    {
        public SaleInvoicePaymentRepo(DbContextOptions<CoreContext> options)
            : base(options)
        {
        }

        public SaleInvoicePaymentRepo()
        {
        }

        public override IEnumerable<SaleInvoicePayments> GetAll()
            => Table.AsNoTracking().OrderBy(x => x.InvoiceID);

        public override IEnumerable<SaleInvoicePayments> GetRange(int skip, int take)
            => GetRange(Table.AsNoTracking().OrderBy(x => x.InvoiceID), skip, take);
    }
}