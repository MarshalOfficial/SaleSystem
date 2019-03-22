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
    public class SaleInvoicePaymentTypeRepo : RepoBase<SaleInvoicePaymentTypes>
    {
        public SaleInvoicePaymentTypeRepo(DbContextOptions<CoreContext> options)
            : base(options)
        {
        }

        public SaleInvoicePaymentTypeRepo()
        {
        }

        public override IEnumerable<SaleInvoicePaymentTypes> GetAll()
            => Table.AsNoTracking().OrderBy(x => x.Title);

        public override IEnumerable<SaleInvoicePaymentTypes> GetRange(int skip, int take)
            => GetRange(Table.AsNoTracking().OrderBy(x => x.Title), skip, take);
    }
}