using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseTask.Models
{
    [Table("HealtInspection")]
    public partial class HealtInspection
    {
        [Key]
        [Column("Healt Inspection Id")]
        public int HealtInspectionId { get; set; }
        [Column("Empolyee Id")]
        public int EmpolyeeId { get; set; }
        [StringLength(50)]
        public string Type { get; set; } = null!;
        [Column("Start Date")]
        public int StartDate { get; set; }
        [Column("End Date")]
        public int? EndDate { get; set; }
    }
}
