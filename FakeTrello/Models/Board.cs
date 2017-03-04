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
        public int BoardId { get; set; }

        public string Name { get; set; }

        public string URL { get; set; }

        //Auxillary (i.e. not required by drive/define relationship, 
        //but good practice to go ahead and implement it)
        public TrelloUser Owner { get; set; }

        public List<List> Lists { get; set; }

    }
}