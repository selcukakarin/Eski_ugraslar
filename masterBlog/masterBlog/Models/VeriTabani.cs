using System.Data.Entity.ModelConfiguration.Conventions;

namespace masterBlog.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class VeriTabani : DbContext
    {
        public VeriTabani()
            : base("name=VeriTabani")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Iletisim> Iletisim { get; set; }  
    }
}
