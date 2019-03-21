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

        
        public IEnumerable<PurchaseInvoiceDetailsTemp> GetAllByUserID(int userid)
            => Table.Where(l => l.UserID == userid).ToList();

    }   
}
