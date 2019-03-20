using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SaleSystemCore.Models
{
    public abstract class EntityBase
    {
        public EntityBase()
        {
            CreateDate = DateTime.Now;
            IsActive = true;
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Timestamp]
        public byte[] TimeStamp { get; set; }

        [Required]
        public DateTime CreateDate { get; set; }

        [Required]
        public bool IsActive { get; set; }
    }
}