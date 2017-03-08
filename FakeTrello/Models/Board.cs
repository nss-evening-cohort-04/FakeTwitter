using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FakeTrello.Models
{
    public class Board
    {
        [Key]
        public int BoardId { get; set; } //Primary key

        public string Name { get; set; } //Board Name

        public string URL { get; set; } //Board URL

        public TrelloUser Owner { get; set; } // 1 to 1 relationship

        public List<List> Lists { get; set; } // 1 to many (lists) relationship
    }
}