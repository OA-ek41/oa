using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace planerApp.Models
{
    public class Notate
    {
        [System.ComponentModel.DataAnnotations.Key] public int id { get; set; }
        public string title { get; set; }
        public string note { get; set; }
    }
}