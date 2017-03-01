using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FakeTrello.Models
{
    public class Card
    {
        [Key]
        public int CardId { get; set; } //Primary key

        public string Name { get; set; } //Card Name

        public string Description { get; set; } //Card Description

        public List List { get; set; } // 1 to 1 relationship

    }
}