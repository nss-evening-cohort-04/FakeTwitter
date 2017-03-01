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

        [MaxLength(255)]
        public string Name { get; set; }

        public List<Card> Cards { get; set; } // one to many link from lists to cards
    }
}