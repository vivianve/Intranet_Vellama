using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseTask.Models
{
    [Table("Rental")]
    public partial class Rental
    {
        [Key]
        [Column("Rental Id")]
        public int RentalId { get; set; }
        [Column("Employee Id")]
        public int EmployeeId { get; set; }
        [Column("Item Code")]
        public int ItemCode { get; set; }
        [Column("Start Date", TypeName = "date")]
        public DateTime StartDate { get; set; }
        [Column("End Date", TypeName = "date")]
        public DateTime? EndDate { get; set; }
        [Column("Branch Id")]
        public int BranchId { get; set; }
    }
}
