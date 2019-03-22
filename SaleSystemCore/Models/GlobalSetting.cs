using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SaleSystemCore.Models
{
    [Table("GlobalSetting")]
    public class GlobalSetting : EntityBase
    {
        public long SaleInvoiceCounter { get; set; }
        public long PurchaseInvoiceCounter { get; set; }
        public long StockAdjustmentInvoiceCounter { get; set; } 
        public long ProductBarcodeCounter { get; set; }
        public string SelectedLanguage { get; set; }    
    }
}
