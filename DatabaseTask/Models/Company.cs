using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseTask.Models
{
    [Table("Company")]
    public partial class Company
    {
        [Key]
        [Column("Company Id")]
        public int CompanyId { get; set; }
        [Column("Company Name")]
        [StringLength(50)]
        public string CompanyName { get; set; } = null!;
        [Column("Company Code")]
        public int CompanyCode { get; set; }
        [Column("Country Id")]
        public int CountryId { get; set; }
        [StringLength(50)]
        public string Aadress { get; set; } = null!;
        public int Phone { get; set; }
        [StringLength(50)]
        public string Email { get; set; } = null!;
    }
}
