using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

//ENTITY is our Object Relational Mapper (ORM) - So it knows how to interpret this information

namespace FakeTrello.Models
{
    public class TrelloUser
    {
        [Key] //this a data annotation - this tells the system who/where the primary key is (w/e is right below it)
        public int TrelloUserId { get; set; } //**THIS IS OUR PRIMARY KEY**

        [MinLength(10)] //you have the ability to stack these properties
        [MaxLength(60)]
        public string Email { get; set; }

        [MaxLength(60)]
        public string UserName { get; set; }

        [MaxLength(60)]
        public string FullName { get; set; }

    }
}