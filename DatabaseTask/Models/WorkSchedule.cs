using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseTask.Models
{
    [Table("Work Schedule")]
    public partial class WorkSchedule
    {
        [Key]
        [Column("Work Schedule Id")]
        public int WorkScheduleId { get; set; }
        [Column("Contract Id")]
        public int ContractId { get; set; }
        [Column("Start Date", TypeName = "date")]
        public DateTime StartDate { get; set; }
        [Column("End Date", TypeName = "date")]
        public DateTime? EndDate { get; set; }
        public int? Hours { get; set; }
        [Column("Over hours")]
        public int? OverHours { get; set; }
    }
}
