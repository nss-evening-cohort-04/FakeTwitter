using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FakeTrello.Models
{
    public class List
    {
        [Key]
        public int ListId { get; set; } //Primary key

        public string Name { get; set; } //List Name

        public Board Board { get; set; } // 1 to 1 relationship

        public List<Card> Cards { get; set; } // 1 to many (cards) relationship
    }
}