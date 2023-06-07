using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseTask.Models
{
    [Table("SalaryAccounting")]
    public partial class SalaryAccounting
    {
        [Key]
        [Column("Salary Accounting Id")]
        public int SalaryAccountingId { get; set; }
        [Column("Payout Id")]
        public int PayoutId { get; set; }
        [Column("Vacation Id")]
        public int? VacationId { get; set; }
        [Column("Sick Leave Id")]
        public int? SickLeaveId { get; set; }
        [Column("Salary Id")]
        public int? SalaryId { get; set; }
        [Column("Work Schedule Id")]
        public int? WorkScheduleId { get; set; }
        [StringLength(50)]
        public string? Comment { get; set; }
    }
}
