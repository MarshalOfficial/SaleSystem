using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SaleSystemCore.Models
{
    [Table("SaleInvoicePaymentTypes")]
    public class SaleInvoicePaymentTypes : EntityBase
    {
        [DataType(DataType.Text), MaxLength(150)]   
        public string Title { get; set; }

        [DataType(DataType.Text), MaxLength(150)]
        public string Description { get; set; }

        #region WhenConnectedToPhysicalPOS

        public bool IsConnectedToPos { get; set; }

        [DataType(DataType.Text), MaxLength(150)]
        public string ConnectedPortType { get; set; }

        [DataType(DataType.Text), MaxLength(150)]
        public string ConnectedPortNumber { get; set; }

        #endregion


        #region WhenUseOnlinePaymentGateway

        [DataType(DataType.Text), MaxLength(150)]
        public string OnlinePaymentUrl { get; set; }

        [DataType(DataType.Text), MaxLength(150)]
        public string OnlinePaymentApi { get; set; }

        [DataType(DataType.Text), MaxLength(150)]
        public string OnlinePaymentKey { get; set; }

        #endregion


    }
}
