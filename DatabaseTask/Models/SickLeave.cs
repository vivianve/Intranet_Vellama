using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseTask.Models
{
    [Table("SickLeave")]
    public partial class SickLeave
    {
        [Key]
        [Column("Sick Leave Id")]
        public int SickLeaveId { get; set; }
        [Column("Employee Id")]
        public int EmployeeId { get; set; }
        [StringLength(50)]
        public string Type { get; set; } = null!;
        [Column("Sick Leave Start Date", TypeName = "date")]
        public DateTime SickLeaveStartDate { get; set; }
        [Column("Sick Leave End Date", TypeName = "date")]
        public DateTime? SickLeaveEndDate { get; set; }
    }
}
