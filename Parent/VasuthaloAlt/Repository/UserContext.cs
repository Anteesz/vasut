using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VasuthaloAlt.Model.Userhandling;

namespace VasuthaloAlt.Repository
{
    class UserContext :DbContext
    {
        private static UserContext Instance
        {
            get
            {
                if (UserContext==null)
                {
                    UserContext = new UserContext();
                }
                return UserContext;
            }   
        }
        public DbSet<User> Users { get; set; }

        private UserContext()
        {
            Database.EnsureCreated();
        }

        protected override void Onconfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Vasuthalo;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}
