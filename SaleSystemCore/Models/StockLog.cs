using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SaleSystemCore.Models
{
    [Table("StockLog")]
    public class StockLog : EntityBase
    {
        public int ProductID { get; set; }
        public decimal Qty { get; set; }
        public int? PurchaseInvoiceID { get; set; }
        public int? SaleInvoiceID { get; set; }
    }
}