using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SaleSystemCore.Models
{
    [Table("ProductsProvider")]
    public class ProductsProvider : EntityBase
    {
        /// <summary>
        /// First and LastName of Product Provider
        /// </summary>
        [DataType(DataType.Text), MaxLength(150)]
        public string Name { get; set; }

        /// <summary>
        /// Company Name of Product Provider
        /// </summary>
        [DataType(DataType.Text), MaxLength(150)]
        public string CompnayName { get; set; }


        /// <summary>
        /// Mobile Number
        /// </summary>
        [DataType(DataType.Text), MaxLength(50)]
        public string Mobile { get; set; }


        /// <summary>
        /// Telephone Number
        /// </summary>
        [DataType(DataType.Text), MaxLength(100)]
        public string Tel { get; set; }

        /// <summary>
        /// Office, shop or factory Address of product provider
        /// </summary>
        public string Address { get; set; }


        /// <summary>
        /// Any description
        /// </summary>
        public string Description { get; set; } 


        /// <summary>
        /// Email Address
        /// </summary>
        [DataType(DataType.Text), MaxLength(150)]
        public string Email { get; set; }


        /// <summary>
        /// Registration Number of product provider's company (if exists)
        /// </summary>
        [DataType(DataType.Text), MaxLength(250)]
        public string RegistrationNo { get; set; }

        /// <summary>
        /// National code of product provider's company (if exists)
        /// </summary>
        [DataType(DataType.Text), MaxLength(150)]
        public string NationalCode { get; set; }

        /// <summary>
        /// Bank Account Information of product provider
        /// </summary>
        [DataType(DataType.Text), MaxLength(150)]
        public string BankAccountInfo { get; set; }

        /// <summary>
        /// Online payment url of product provider (if exists)
        /// </summary>
        [DataType(DataType.Text), MaxLength(500)]
        public string OnlinePaymentUrl { get; set; }

        /// <summary>
        /// It used when product provider has online payment url and online wallet
        /// </summary>
        [DataType(DataType.Text), MaxLength(1000)]
        public string OnlinePaymentUrlApiKey { get; set; }

    }
}
