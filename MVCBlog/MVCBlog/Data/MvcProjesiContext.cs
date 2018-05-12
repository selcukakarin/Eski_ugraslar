using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCBlog.Data
{
    public class MvcProjesiContext:DbContext
    {
        public DbSet<Etiket> Etikets { get; set; }
        public DbSet<Makale> Makales { get; set; }
        public DbSet<Uye> Uyes { get; set; }
        public DbSet<Yorum> Yorums { get; set; }

    }
}