using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseTask.Models
{
    [Table("Salary")]
    public partial class Salary
    {
        [Key]
        [Column("Salary Id")]
        public int SalaryId { get; set; }
        [Column("Empolyee Id")]
        public int EmpolyeeId { get; set; }
        [Column("Current Month")]
        [StringLength(50)]
        public string? CurrentMonth { get; set; }
        [Column("Bruto ")]
        public double? Bruto { get; set; }
        [Column("Tax free amount")]
        public int? TaxFreeAmount { get; set; }
        [StringLength(50)]
        public string? Comment { get; set; }
        [Column("Tax amount")]
        public double? TaxAmount { get; set; }
        public double? Neto { get; set; }
        [Column("Payment Date", TypeName = "date")]
        public DateTime? PaymentDate { get; set; }
        [Column("Bank Account")]
        public int? BankAccount { get; set; }
    }
}
