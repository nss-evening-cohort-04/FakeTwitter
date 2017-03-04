﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FakeTrello.Models
{
    public class List
    {
        [Key]
        public int ListId { get; set; }

        public string Name { get; set; }


        // Auxiliary : given a card instance,
        // return the list it belongs to 
        public List BelongsTo { get; set; }

        public List<Card> Cards { get; set; } // 1 to many (card) relationship
    }
}