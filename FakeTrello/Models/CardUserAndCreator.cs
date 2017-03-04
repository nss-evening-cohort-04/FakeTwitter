using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FakeTrello.Models
{
    public class CardUserAndCreator
    {
        public int TrelloUserId { get; set; }

        public int CardCreatorID { get; set; }
    }
}