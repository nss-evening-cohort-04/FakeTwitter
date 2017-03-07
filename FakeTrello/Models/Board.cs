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

        [Required]
        [MaxLength(255)]
        public string Title { get; set; }

        public List<List> Lists { get; set; }
    }
}