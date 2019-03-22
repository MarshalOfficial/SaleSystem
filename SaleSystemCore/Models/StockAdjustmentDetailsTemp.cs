using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SaleSystemCore.Models
{
    [Table("StockAdjustmentDetailsTemp")]
    public class StockAdjustmentDetailsTemp : EntityBase
    {
        public int UserID { get; set; }

        public int ProductID { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Qty { get; set; }

        public string Description { get; set; }
    }
}
