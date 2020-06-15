using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EFCore.Testing
{
    public class TestDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-143K4FV\SQLEXPRESS;Initial Catalog=TestDb;Integrated Security=True");
            //base.OnConfiguring(optionsBuilder);
        }
    }
}
