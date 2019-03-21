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
        public int TypeID { get; set; } // 1: PurchaseInvoice, 2: SaleInvoice
    }
}