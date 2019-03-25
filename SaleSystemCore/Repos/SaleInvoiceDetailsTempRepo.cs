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
    public class SaleInvoiceDetailsTempRepo : RepoBase<SaleInvoiceDetailsTemp>
    {
        public SaleInvoiceDetailsTempRepo(DbContextOptions<CoreContext> options)
            : base(options)
        { }
        public SaleInvoiceDetailsTempRepo()
        { }

        public IEnumerable<SaleInvoiceDetailsTemp> GetAllByUserID(int userid)
            => Table.Where(l => l.UserID == userid).ToList();
    }
}
