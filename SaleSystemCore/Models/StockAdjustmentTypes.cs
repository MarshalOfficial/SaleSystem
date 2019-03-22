using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SaleSystemCore.Models
{
    [Table("StockAdjustmentTypes")]
    public class StockAdjustmentTypes : EntityBase
    {
        [DataType(DataType.Text), MaxLength(250)]
        public string Title { get; set; }
    }
}
