using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using planerApp.Models;

namespace planerApp.Models
{
    public class NotateContext : DbContext

    {
        public DbSet<Notate> Notates {get; set; }
        public DbSet<Tassk> Tassks { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Media> Medias { get; set; }
    }
    public class NotateDbInitializer : DropCreateDatabaseAlways<NotateContext>
    {
        protected override void Seed(NotateContext db)
        {
            db.Notates.Add(new Notate { title = "З чого почати?", note = "Почнемо із знайомством з системою" });
            db.Notates.Add(new Notate { title = "Оцініть нашу розробку", note = "Будь ласка, напишіть нам на пошту, що ви думаєте про наш додаток" });

            db.Tassks.Add(new Tassk { T_title = "Спробуй створити своє перше завдання!", T_desc = "Опиши своє завдання тут", T_check = false, T_data = DateTime.Now });

            base.Seed(db);
        }
    }
}