using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseTask.Models
{
    public partial class DepartmentEmpolyee
    {
        [Key]
        [Column("Department Employee Id")]
        public int DepartmentEmployeeId { get; set; }
        [Column("Empolyee Id")]
        public int EmpolyeeId { get; set; }
        [Column("Department Id")]
        public int DepartmentId { get; set; }
        [Column("Start Date", TypeName = "date")]
        public DateTime StartDate { get; set; }
        [Column("End Date", TypeName = "date")]
        public DateTime? EndDate { get; set; }
    }
}
