using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

//Entity is our Object Relational Mapper (ORM)

namespace FakeTrello.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; } //Primary Key

        [Required]
        [MaxLength(255)]
        public string PasswordHash { get; set; }

        [Required]
        [MaxLength(255)]
        public string FullName { get; set; }

        [Required]
        [MaxLength(255)]
        public string Email { get; set; }

        public List<Board> Boards { get; set; } // 1 to many (boards) relationship

        public List<List> Lists { get; set; } // 1 to many

        public List<Card> Cards { get; set; } // 1 to many
    }
}