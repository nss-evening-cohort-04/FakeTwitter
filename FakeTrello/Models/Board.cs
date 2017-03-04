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

        public string Url { get; set; }
        
        public TrelloUser Owner { get; set; }

        public ICollection<TrelloList> TrelloLists { get; set; }
    }
}