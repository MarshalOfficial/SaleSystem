using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SaleSystemCore.Models
{
    [Table("GlobalSetting")]
    public class GlobalSetting : EntityBase
    {
        // too keep sale and buy invoice number counters , selected language , product barcode counter and etc
    }
}
