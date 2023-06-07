using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseTask.Models
{
    [Table("Child")]
    public partial class Child
    {
        [Key]
        [Column("Child Id")]
        public int ChildId { get; set; }
        [Column("Employee Id")]
        public int EmployeeId { get; set; }
        [Column("Person Id")]
        public int PersonId { get; set; }
    }
}
