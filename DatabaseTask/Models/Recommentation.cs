using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseTask.Models
{
    public partial class Recommentation
    {
        [Key]
        [Column("Recommentatio Id")]
        public int RecommentatioId { get; set; }
        [Column("Sending Time")]
        public TimeSpan SendingTime { get; set; }
        public string Comment { get; set; } = null!;
        [Column("Company Id")]
        public int CompanyId { get; set; }
    }
}
