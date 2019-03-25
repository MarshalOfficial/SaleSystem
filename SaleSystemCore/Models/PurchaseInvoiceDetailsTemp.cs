using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SaleSystemCore.Models
{
    /// <summary>
    /// user when is adding items and adjusting them,
    /// items add in this table and after save invoice then items copy to main table means PurchaseInvoiceDetails
    /// </summary>
    [Table("PurchaseInvoiceDetailsTemp")]
    public class PurchaseInvoiceDetailsTemp : EntityBase
    {
        /// <summary>
        /// indicate this temp item is for which user
        /// </summary>
        public int UserID { get; set; }

        /// <summary>
        /// Indicate Product
        /// </summary>
        public int ProductID { get; set; }

        /// <summary>
        /// Purchase Price when we are registring invoice
        /// </summary>
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }


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
