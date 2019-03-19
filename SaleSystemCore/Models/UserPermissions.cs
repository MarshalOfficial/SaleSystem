using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SaleSystemCore.Models
{
    [Table("UserPermissions")]
    public class UserPermissions : EntityBase
    {
        public int UserID { get; set; }

        [DataType(DataType.Text), MaxLength(150)]
        public string PermKey { get; set; } 
    }
}
