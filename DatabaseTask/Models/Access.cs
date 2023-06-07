using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseTask.Models
{
    [Table("Access")]
    public partial class Access
    {
        [Key]
        [Column("Access Id")]
        public int AccessId { get; set; }
        [Column("Access Name")]
        [StringLength(50)]
        public string AccessName { get; set; } = null!;
        [Column("Start Date", TypeName = "date")]
        public DateTime? StartDate { get; set; }
        [Column("End Date", TypeName = "date")]
        public DateTime? EndDate { get; set; }
        [StringLength(50)]
        public string? Comment { get; set; }
    }
}
