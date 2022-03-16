using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApplication31.Models
{
    public partial class User
    {
        [Key]
        public int Id { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string? Name { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Surname { get; set; }
        [StringLength(9)]
        [Unicode(false)]
        public string? PhoneNumber { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? City { get; set; }
    }
}
