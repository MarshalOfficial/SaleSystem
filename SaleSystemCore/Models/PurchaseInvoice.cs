using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SaleSystemCore.Models
{
    [Table("PurchaseInvoice")]
    public class PurchaseInvoice : EntityBase   
    {
        /// <summary>
        /// Invoice Number that printed on Invoice paper and generate from Product Provider system
        /// </summary>
        [DataType(DataType.Text), MaxLength(150)]
        public string InvoiceNumber { get; set; }

        /// <summary>
        /// Invoice That that printed on Invoice paper and generate from Product Provider system
        /// </summary>
        public DateTime? InvoiceDate { get; set; }

        /// <summary>
        /// Indicate that this invoice has registered by which user
        /// </summary>
        public int UserID { get; set; }

        public int InvoiceType { get; set; }    

        /// <summary>
        /// Indicate Invoice Product Provider and shows we bought invoice items from which provider
        /// </summary>
        public int? ProviderID { get; set; }

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
