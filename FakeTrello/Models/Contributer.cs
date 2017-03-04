using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FakeTrello.Models
{
    public class Contributer
    {
        [Key]
        public int TrelloUserId { get; set; }

        public int CardId { get; set; }
    }
}