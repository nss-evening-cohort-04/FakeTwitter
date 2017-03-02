using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FakeTrello.Models
{
    public class Contributor
    {
       [Key]
       public int TrelloUserId {get; set;}

        //OR
       
       public List<TrelloUser> TrellLink { get; set; }
    }
}