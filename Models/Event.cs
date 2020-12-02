using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace planerApp.Models
{
    public class Event
    {
        [Key] public int e_id { get; set; }
        public string e_title { get; set; }
        public DateTime e_date { get; set; }

    }
}