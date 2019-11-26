using GriffonWpfClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GriffonWpfClassLibrary.Database
{
    public class GriffonWpfContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public GriffonWpfContext()
        {
            if (this.Database.CreateIfNotExists())
            {
                for (int i = 0; i < 10; i++)
                {
                    Users.Add(new User("first" + i, "lastname" + i, DateTime.Now, "l" + i, "p" + i));
                }

                this.SaveChanges();
            }
        }
    }
}
