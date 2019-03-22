using SaleSystemCore.Repos.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SaleSystemCore.Models;
using Microsoft.EntityFrameworkCore;
using SaleSystemCore.EF;

namespace SaleSystemCore.Repos
{
    public class GlobalSettingRepo : RepoBase<GlobalSetting>
    {
        public GlobalSettingRepo(DbContextOptions<CoreContext> options)
            : base(options)
        { }
        public GlobalSettingRepo()
        { }

        public long GetPurchaseInvoiceCounter()
        {
            var obj = Table.First();
            var counter = obj.PurchaseInvoiceCounter;
            obj.PurchaseInvoiceCounter++;
            SaveChanges();
            return counter;
        }

        public long GetSaleInvoiceCounter() 
        {
            var obj = Table.First();
            var counter = obj.SaleInvoiceCounter;
            obj.SaleInvoiceCounter++;
            SaveChanges();
            return counter;
        }

        public long GetStockAdjustmentCounter() 
        {
            var obj = Table.First();
            var counter = obj.StockAdjustmentInvoiceCounter;
            obj.StockAdjustmentInvoiceCounter++;
            SaveChanges();
            return counter;
        }


        public long GetBarcodeCounter() 
        {
            var obj = Table.First();
            var counter = obj.ProductBarcodeCounter;
            obj.ProductBarcodeCounter++;
            SaveChanges();
            return counter;
        }

    }
}
