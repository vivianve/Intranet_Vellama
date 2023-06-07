using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseTask.Models
{
    [Table("Branch")]
    public partial class Branch
    {
        [Key]
        [Column("Branch Id")]
        public int BranchId { get; set; }
        [Column("Company Id")]
        public int CompanyId { get; set; }
        [Column("Branch Name")]
        [StringLength(50)]
        public string BranchName { get; set; } = null!;
        [Column("Company Code")]
        public int CompanyCode { get; set; }
        [Column("Country Id")]
        public int CountryId { get; set; }
        [StringLength(50)]
        public string Address { get; set; } = null!;
        public int Phone { get; set; }
        [StringLength(50)]
        public string Email { get; set; } = null!;
    }
}
