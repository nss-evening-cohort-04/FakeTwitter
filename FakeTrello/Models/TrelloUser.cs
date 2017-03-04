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

        public ApplicationUser BaseUser { get; set; } //this is creating the relationship btw tables (1 to 1)- this is how you tie together classes
        //ApplicationUser is from the IdentityModels file

        //****List<Board> and Icollection<Board> are navigation properties
        public List<Board> Boards { get; set; } // 1 to many (boards) relationship

        public ICollection<Board> Boards { get; set; } // this is the same as the above- they are both  nav properties

    }
}