using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseTask.Models
{
    [Table("Training")]
    public partial class training
    {
        [Key]
        [Column("Training Id")]
        public int TrainingId { get; set; }
        [StringLength(50)]
        public string Name { get; set; } = null!;
        [Column("Training Start Date", TypeName = "date")]
        public DateTime TrainingStartDate { get; set; }
        [Column("Training End Date", TypeName = "date")]
        public DateTime? TrainingEndDate { get; set; }
        [Column("Employee Id")]
        public int EmployeeId { get; set; }
        public string? Comment { get; set; }
    }
}
