using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseTask.Models
{
    [Table("Contract")]
    public partial class Contract
    {
        [Key]
        [Column("Contract Id")]
        public int ContractId { get; set; }
        [Column("Employee Id")]
        public int EmployeeId { get; set; }
        [Column("Start Date", TypeName = "date")]
        public DateTime StartDate { get; set; }
        [Column("End Date", TypeName = "date")]
        public DateTime? EndDate { get; set; }
        [Column("Preparing date", TypeName = "date")]
        public DateTime? PreparingDate { get; set; }
        [Column("Contract Type")]
        public long ContractType { get; set; }
        public double Workload { get; set; }
        public int? Annex { get; set; }
        public int Salary { get; set; }
    }
}
