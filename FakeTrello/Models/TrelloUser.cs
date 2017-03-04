using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

// Entity is our ORM (Object Relational Mapper) and it knows how to relate this C# class to a DB table
namespace FakeTrello.Models
{
    public class TrelloUser //this will be the table name (TrelloUsers)
    {
        [Key]
        public int TrelloUserId { get; set; } //Primary key

        [MinLength(10)]
        [MaxLength(60)]
        public string Email { get; set; } //user email

        [MaxLength(60)]
        public string Username { get; set; } //username

        [MaxLength(60)]
        public string FullName { get; set; } //user Full Name

        public ApplicationUser BaseUser { get; set; } // 1 to 1 relationship

        public List<Board> Boards { get; set; } // 1 to many (boards) relationship
    }
}