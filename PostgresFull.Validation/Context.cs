using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostgresFull.Validation.Model;

namespace PostgresFull.Validation
{
    public class Context : DbContext
    {
        public Context()
        : base("DefaultConnection")
        {

        }

        public DbSet<Person> Person { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().ToTable("person", "public");
            base.OnModelCreating(modelBuilder);
        }
    }
}
