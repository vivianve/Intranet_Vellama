using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseTask.Models
{
    [Table("Country")]
    public partial class Country
    {
        [Key]
        [Column("Country Id")]
        public int CountryId { get; set; }
        [StringLength(50)]
        public string Name { get; set; } = null!;
    }
}
