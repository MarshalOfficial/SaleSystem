using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SaleSystemCore.Models
{
    [Table("StockAdjustmentDetails")]
    public class StockAdjustmentDetails : EntityBase
    {
        public int InvoiceID { get; set; }

        public int ProductID { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Qty { get; set; }

        public string Description { get; set; }
    }
}
