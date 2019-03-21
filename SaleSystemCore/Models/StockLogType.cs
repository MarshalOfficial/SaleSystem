using System.ComponentModel.DataAnnotations.Schema;

namespace SaleSystemCore.Models
{
    [Table("StockLogType")]
    public class StockLogType : EntityBase
    {
        public string Title { get; set; }  
    }
}