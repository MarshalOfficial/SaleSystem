using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SaleSystemCore.Models
{
    [Table("SaleInvoiceDetails")]
    public class SaleInvoiceDetails : EntityBase
    {
        /// <summary>
        /// Indicate that this item belongs to which sale invoice
        /// </summary>
        public int InvoiceID { get; set; }

        /// <summary>
        /// Indicate Product
        /// </summary>
        public int ProductID { get; set; }

        /// <summary>
        /// sale Price when we are registring invoice
        /// </summary>
        [Column(TypeName = "decimal(18, 2)")]
        public decimal SalePrice { get; set; }


        /// <summary>
        /// Purchase Price when we are registring invoice
        /// </summary>
        [Column(TypeName = "decimal(18, 2)")]
        public decimal PurchasePrice { get; set; }  


        /// <summary>
        /// Count of product in invoice
        /// </summary>
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Qty { get; set; }

        /// <summary>
        /// discount of this product
        /// </summary>
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Discount { get; set; }

        /// <summary>
        /// vat of this product
        /// </summary>
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Vat { get; set; }

        /// <summary>
        /// description
        /// </summary>
        public string Description { get; set; }

        public decimal? RowPrice { get; set; }
    }
}
