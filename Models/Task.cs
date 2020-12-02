using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace planerApp.Models
{
    public class Tassk
    {
        public int T_id { get; set; }
        public string T_title { get; set; }
        public string T_desc { get; set; }
        public DateTime t_data { get; set; }
    }
}