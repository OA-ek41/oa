using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace planerApp.Models
{
    public class Tassk
    {

        [Key] public int Id { get; set; }
        public string T_title { get; set; }
        public string T_desc { get; set; }
        public DateTime t_data { get; set; }
    }
}