using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SaleSystemCore.Models
{
    [Table("Customers")]
    public class Customer : EntityBase
    {
        [DataType(DataType.Text), MaxLength(150)]
        public string FirstName { get; set; }

        [DataType(DataType.Text), MaxLength(150)]
        public string LastName { get; set; }

        [DataType(DataType.Text), MaxLength(150)]
        public string Mobile { get; set; }

        [DataType(DataType.Text), MaxLength(150)]
        public string Tel { get; set; }

        [DataType(DataType.Text), MaxLength(1000)]
        public string Address { get; set; }

        [DataType(DataType.Text), MaxLength(150)]
        public string Instagram { get; set; }

        [DataType(DataType.Text), MaxLength(150)]
        public string Email { get; set; }

        public string Description { get; set; }

        public DateTime? BirthDate { get; set; }

        public DateTime? MarriageDate { get; set; }

    }
}
