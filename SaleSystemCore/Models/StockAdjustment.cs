using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SaleSystemCore.Models
{
    [Table("StockAdjustment")]
    public class StockAdjustment : EntityBase
    {
        
        [DataType(DataType.Text), MaxLength(150)]
        public string InvoiceNumber { get; set; }
            
        public DateTime? InvoiceDate { get; set; }

        public int UserID { get; set; }

        public bool IsOutput { get; set; }

        public int Type { get; set; }    
        
        public string Description { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal? SumPrice { get; set; }
    }
}
