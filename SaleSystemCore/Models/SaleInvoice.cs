using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SaleSystemCore.Models
{
    [Table("SaleInvoice")]
    public class SaleInvoice : EntityBase
    {
        /// <summary>
        /// Invoice Number that generated from counters
        /// </summary>
        [DataType(DataType.Text), MaxLength(150)]
        public string InvoiceNumber { get; set; }

        /// <summary>
        /// Indicate Customer of invoice who buy these items from us
        /// </summary>
        public int? CustomerID { get; set; }

        /// <summary>
        /// Indicate that this invoice has registered by which user
        /// </summary>
        public int UserID { get; set; }

        /// <summary>
        /// Description of Invoice (optional to fill)
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// show sum price of invoice
        /// </summary>
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? SumPrice { get; set; }

        /// <summary>
        /// sum discount of invoice
        /// </summary>
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? SumDiscount { get; set; }

        /// <summary>
        /// sum vat tax of invoice
        /// </summary>
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? SumVat { get; set; }

        public decimal? FinalPrice { get; set; }    
    }
}
