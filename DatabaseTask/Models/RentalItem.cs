using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseTask.Models
{
    [Table("RentalItem")]
    public partial class RentalItem
    {
        [Key]
        [Column("Rental Item Id")]
        public int RentalItemId { get; set; }
        [Column("Item Name")]
        [StringLength(50)]
        public string ItemName { get; set; } = null!;
        [Column("Item Code")]
        public int ItemCode { get; set; }
        [Column("Start Date", TypeName = "date")]
        public DateTime? StartDate { get; set; }
        [Column("End Date", TypeName = "date")]
        public DateTime? EndDate { get; set; }
        [Column("Branch Id")]
        public int BranchId { get; set; }
    }
}
