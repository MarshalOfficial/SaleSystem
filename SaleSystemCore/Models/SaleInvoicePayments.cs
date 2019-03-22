using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SaleSystemCore.Models
{
    [Table("SaleInvoicePayments")]
    public class SaleInvoicePayments : EntityBase
    {
        public int InvoiceID { get; set; }

        public int PayTypeID { get; set; }  

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Value { get; set; }  

        public string Description { get; set; }
    }
}
