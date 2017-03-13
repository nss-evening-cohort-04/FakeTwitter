﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FakeTrello.Models
{
    public class Collaborator
    {
        [Key]
        public int CollaboratorId { get; set; }

        public string ApplicationUserId { get; set; }
        public int CardId { get; set; }
    }
}