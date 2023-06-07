using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseTask.Models
{
    [Table("Vacation")]
    public partial class Vacation
    {
        [Key]
        [Column("Vacation Id")]
        public int VacationId { get; set; }
        [Column("Employee Id")]
        public int EmployeeId { get; set; }
        [Column("Vacation Type Id")]
        public int VacationTypeId { get; set; }
        [Column("Vacation Start Date", TypeName = "date")]
        public DateTime VacationStartDate { get; set; }
        [Column("Vacation End Date", TypeName = "date")]
        public DateTime? VacationEndDate { get; set; }
        public string? Comment { get; set; }
    }
}
