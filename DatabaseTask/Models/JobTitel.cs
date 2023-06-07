using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseTask.Models
{
    public partial class JobTitel
    {
        [Key]
        [Column("Job Titel Id")]
        public int JobTitelId { get; set; }
        [StringLength(50)]
        public string Titel { get; set; } = null!;
        [Column("Start Date", TypeName = "date")]
        public DateTime StartDate { get; set; }
        [Column("End Date", TypeName = "date")]
        public DateTime? EndDate { get; set; }
    }
}
