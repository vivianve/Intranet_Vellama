using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseTask.Models
{
    [Table("Employee_Access")]
    public partial class EmployeeAccess
    {
        [Key]
        [Column("Employee_Access Id")]
        public int EmployeeAccessId { get; set; }
        [Column("Access Id")]
        public int AccessId { get; set; }
        [Column("Empolyee Id")]
        public int EmpolyeeId { get; set; }
        [Column("Start Date", TypeName = "date")]
        public DateTime? StartDate { get; set; }
        [Column("End Date", TypeName = "date")]
        public DateTime? EndDate { get; set; }
    }
}
