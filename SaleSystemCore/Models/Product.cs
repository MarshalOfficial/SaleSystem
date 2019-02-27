using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SaleSystemCore.Models
{
    [Table("Products")]
    public class Product : EntityBase
    {
        /// <summary>
        /// Product Name
        /// </summary>
        [DataType(DataType.Text), MaxLength(250)]
        public string Name { get; set; }


        /// <summary>
        /// Product Barcode
        /// </summary>
        [DataType(DataType.Text), MaxLength(500)]
        public string Barcode { get; set; }

        /// <summary>
        /// Sale Price that come to sale invoice
        /// </summary>
        [Column(TypeName = "decimal(18, 2)")]
        public decimal SalePrice { get; set; }

        /// <summary>
        /// Purchase price that used when we buy product from product Providers
        /// </summary>
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? PurchasePrice { get; set; }

        /// <summary>
        /// ((saleprice - buyprice)/buyprice)*100
        /// Markup (accounting idiom)
        /// </summary>
        public decimal? ProfitMarkup { get; set; }  


        /// <summary>
        /// ((saleprice - buyprice)/saleprice)*100
        /// /// Margin (accounting idiom)
        /// </summary>
        public decimal? ProfitMargin { get; set; }


        /// <summary>
        /// Discount Percent
        /// </summary>
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Discount { get; set; }

        /// <summary>
        /// VAT tax rate
        /// </summary>
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Vat { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        [DataType(DataType.Text)]
        public string Description { get; set; }

        /// <summary>
        /// Specified that this product belongs to which brand
        /// </summary>
        public int? BrandID { get; set; }

        /// <summary>
        /// Specified that this product belongs to which category
        /// </summary>
        public int? CategoryID { get; set; }

        /// <summary>
        /// Specified that this product brought by which provider
        /// </summary>
        public int? ProviderID { get; set; }
    }
}
