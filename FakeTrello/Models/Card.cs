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

        public string Title { get; set; } //Card Name

        public string Description { get; set; } //Card Description

        // Auxiliary: given a card instance,
        // return the list it belongs to.
        public List BelongsTo { get; set; }
    }
}