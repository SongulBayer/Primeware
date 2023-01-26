using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrate
{
   public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-NDD1JV0;database=PrimewareDb;integrated security=true;");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Reference> References{ get; set; }
        public DbSet<Admin> Admins{ get; set; }
        public DbSet<About> Abouts{ get; set; }
    }
}
