using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseTask.Models
{
    [Table("Person")]
    public partial class Person
    {
        [Key]
        [Column("Person Id")]
        public int PersonId { get; set; }
        [Column("First Name")]
        [StringLength(50)]
        public string FirstName { get; set; } = null!;
        [Column("Last Name")]
        [StringLength(50)]
        public string LastName { get; set; } = null!;
        [StringLength(10)]
        public string Gender { get; set; } = null!;
        [Column(TypeName = "date")]
        public DateTime Birthday { get; set; }
        [Column("Id Code")]
        public int IdCode { get; set; }
        public int Phone { get; set; }
        [StringLength(50)]
        public string Email { get; set; } = null!;
    }
}
