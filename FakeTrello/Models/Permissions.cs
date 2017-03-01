using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FakeTrello.Models
{
    public class Permissions
    {
        [Key]
        public int PermissionId { get; set; }

        public string Name { get; set; }
    }
}