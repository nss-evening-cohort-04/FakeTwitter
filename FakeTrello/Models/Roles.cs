using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FakeTrello.Models
{
    public class Roles
    {
        [Key]
        public int RoleId { get; set; }

        public string Name { get; set; }

        public List<Permissions> Permissions { get; set; }

        public List<Board> Board { get; set; }

    }
}