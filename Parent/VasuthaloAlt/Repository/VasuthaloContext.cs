using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VasuthaloAlt.Model;

namespace VasuthaloAlt.Repository
{
    public class VasuthaloContext : DbContext
    {
        private static VasuthaloContext context = null;
        public static VasuthaloContext Instance
        {
            get
            {
                if (context==null)
                {
                    context = new VasuthaloContext();
                }
                return context;
            }
        }

        public DbSet<City> Cities { get; set; }

        private VasuthaloContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Vasuthalo;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}
