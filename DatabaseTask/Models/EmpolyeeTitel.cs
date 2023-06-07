using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseTask.Models
{
    [Table("EmpolyeeTitel")]
    public partial class EmpolyeeTitel
    {
        [Key]
        [Column("Empolyee Titel Id")]
        public int EmpolyeeTitelId { get; set; }
        [Column("Employee Id")]
        public int EmployeeId { get; set; }
        [Column("Start Date", TypeName = "date")]
        public DateTime StartDate { get; set; }
        [Column("End Date", TypeName = "date")]
        public DateTime? EndDate { get; set; }
        [StringLength(50)]
        public string Titel { get; set; } = null!;
    }
}
