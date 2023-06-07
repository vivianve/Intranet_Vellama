using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseTask.Models
{
    [Table("PayoutType")]
    public partial class PayoutType
    {
        [Key]
        [Column("Payout Id")]
        public int PayoutId { get; set; }
        [StringLength(50)]
        public string Name { get; set; } = null!;
    }
}
