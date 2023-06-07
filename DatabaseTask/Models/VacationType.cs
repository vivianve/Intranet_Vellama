using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseTask.Models
{
    [Table("Vacation Type")]
    public partial class VacationType
    {
        [Key]
        [Column("Vacation Type Id")]
        public int VacationTypeId { get; set; }
        [StringLength(50)]
        public string Name { get; set; } = null!;
        [Column("Vacation Days Amount")]
        public int VacationDaysAmount { get; set; }
        public string Comment { get; set; } = null!;
    }
}
