using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TD.Model.Entities;

namespace TD.DataAccess.Implementations.EF.Contexts
{
    public class ToDoListContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server)./MGSERVER; database=TODOLİST; trusted_connection)=true;");
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Order> Orders { get; set; }

    }
}
