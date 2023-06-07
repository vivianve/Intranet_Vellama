using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseTask.Models
{
    [Table("Hint")]
    public partial class Hint
    {
        [Key]
        [Column("Hint Id")]
        public int HintId { get; set; }
        [Column("Employee Id")]
        public int EmployeeId { get; set; }
        public string Comment { get; set; } = null!;
        [Column("Add Date", TypeName = "date")]
        public DateTime AddDate { get; set; }
    }
}
