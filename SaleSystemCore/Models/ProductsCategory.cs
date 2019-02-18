using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SaleSystemCore.Models
{
    [Table("ProductsCategory")]
    public class ProductsCategory : EntityBase
    {
        [DataType(DataType.Text),MaxLength(150)]
        public string Title { get; set; }   
    }
}
