using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SaleSystemCore.Models
{
    [Table("ProductsBrand")]
    public class ProductsBrand : EntityBase
    {
        [DataType(DataType.Text), MaxLength(150)]
        public string Title { get; set; }

        [DataType(DataType.Text)]
        public string Description { get; set; } 
    }
}