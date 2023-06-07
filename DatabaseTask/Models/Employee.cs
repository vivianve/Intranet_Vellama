using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseTask.Models
{
    [Table("Employee")]
    public partial class Employee
    {
        [Key]
        [Column("Empolyee Id")]
        public int EmpolyeeId { get; set; }
        [Column("Employee Number")]
        public int EmployeeNumber { get; set; }
        [Column("Person Id")]
        public int PersonId { get; set; }
        [Column("Contract Number")]
        public int ContractNumber { get; set; }
        [Column("Contract Start Date", TypeName = "date")]
        public DateTime ContractStartDate { get; set; }
        [Column("Contract End Date", TypeName = "date")]
        public DateTime? ContractEndDate { get; set; }
        public int Phone { get; set; }
        [StringLength(50)]
        public string Email { get; set; } = null!;
        [Column("Work Phone")]
        public int? WorkPhone { get; set; }
        [Column("Bank account")]
        public int BankAccount { get; set; }
        [Column("Tax free amount")]
        public int? TaxFreeAmount { get; set; }
    }
}
