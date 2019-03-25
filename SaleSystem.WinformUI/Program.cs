using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SaleSystemCore.Logic;
using SaleSystemCore.Models;

namespace SaleSystem.WinformUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            SaleSystemCore.Logic.Cash.LoginUser("admin", "admin");

            // insert product test
            //SaleSystemCore.Logic.Cash._ProductModule.AddProduct(new Product()
            //{ Name = "dest", Barcode = "3", SalePrice = 123, PurchasePrice = 12 });
            //SaleSystemCore.Logic.Cash._ProductModule.AddProduct(new Product()
            //{ Name = "rest", Barcode = "4", SalePrice = 456, PurchasePrice = 45 });

            //var lstprd = Cash._ProductModule.GetAllProducts();


            // insert purchase invoice test
            //Cash._PurchaseModule.AddDetailToTemp(new PurchaseInvoiceDetailsTemp()
            //{ ProductID = 1, Qty = 10, Vat = 9, Price = 12, Discount = 5, Description = "adasd", UserID = 1 });
            //Cash._PurchaseModule.AddDetailToTemp(new PurchaseInvoiceDetailsTemp()
            //{ ProductID = 2, Qty = 13, Vat = 9, Price = 42, Discount = 2.5m, Description = "adasd", UserID = 1 });
            //Cash._PurchaseModule.AddDetailToTemp(new PurchaseInvoiceDetailsTemp()
            //{ ProductID = 3, Qty = 23, Vat = 9, Price = 12, Discount = 7.8m, Description = "adasd", UserID = 1 });

            //Cash._PurchaseModule.SavePurchaseInvoice(1, 1, "test", 0, DateTime.Now);


            // insert stock adjustment invoice test
            //Cash._StockAdjustmentModule.AddDetailToTemp(new StockAdjustmentDetailsTemp()
            //{ ProductID = 1, Qty = 1, Price = 12, Description = "memo1", UserID = 1 });
            //Cash._StockAdjustmentModule.AddDetailToTemp(new StockAdjustmentDetailsTemp()
            //{ ProductID = 2, Qty = 2, Price = 42, Description = "memo2", UserID = 1 });
            //Cash._StockAdjustmentModule.AddDetailToTemp(new StockAdjustmentDetailsTemp()
            //{ ProductID = 3, Qty = 3, Price = 12, Description = "memo3", UserID = 1 });

            //Cash._StockAdjustmentModule.SaveStockAdjustmentInvoice(1, 2, true, "memooo", DateTime.Now);



            // insert sale invoice test
            //Cash._SaleModule.AddDetailToTemp(new SaleInvoiceDetailsTemp()
            //    {ProductID = 1, Qty = -1, SalePrice = 123, Description = "memo1", UserID = 1, Discount = 3.5m});
            ////Cash._SaleModule.AddDetailToTemp(new SaleInvoiceDetailsTemp()
            ////{ ProductID = 2, Qty = 2, SalePrice = 456, Description = "memo2", UserID = 1 ,Vat = 9});

            //Cash._SaleModule.SaveSaleInvoice(1, 1, "saletest",
            //    new List<SaleInvoicePayments>() {new SaleInvoicePayments() {PayTypeID = 1, Value = -118.695m}});

            Application.Run(new Form1());
        }
    }
}