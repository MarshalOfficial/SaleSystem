using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SaleSystemCore.Models
{
    [Table("Users")]
    public class User : EntityBase
    {
        [DataType(DataType.Text), MaxLength(150)]
        public string UserName { get; set; }

        [DataType(DataType.Text), MaxLength(150)]
        public string Password { get; set; }

        [DataType(DataType.Text), MaxLength(150)]
        public string FirstName { get; set; }

        [DataType(DataType.Text), MaxLength(150)]
        public string LastName { get; set; }

        [DataType(DataType.Text), MaxLength(150)]
        public string Mobile { get; set; }

        [DataType(DataType.Text)]
        public string Address { get; set; }

        [DataType(DataType.Text), MaxLength(150)]
        public string Email { get; set; }

        [DataType(DataType.Text)]
        public string Description { get; set; }

        public bool IsAdmin { get; set; }
    }
}
