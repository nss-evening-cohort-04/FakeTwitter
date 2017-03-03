using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//Entity is our Object Relational Mapper (ORM)

namespace FakeTrello.Models
{
    public class TrelloUser
    {
        [Key]
        public int TrelloUserId { get; set; } //Primary Key
        public string Email { get; set; }
        public string Username { get; set; }
        public string FullName { get; set; }
    }
}