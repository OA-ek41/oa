using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace planerApp.Models
{
    public class NotateContext : DbContext

    {
        public DbSet<Notate> Notates {get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Media> Medias { get; set; }
    }
}