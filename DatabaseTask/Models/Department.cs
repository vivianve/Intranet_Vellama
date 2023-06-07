using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseTask.Models
{
    [Table("Department")]
    public partial class Department
    {
        [Key]
        [Column("Department Id")]
        public int DepartmentId { get; set; }
        [StringLength(50)]
        public string Name { get; set; } = null!;
        [Column("Branch Id")]
        public int BranchId { get; set; }
        public int? Status { get; set; }
    }
}
