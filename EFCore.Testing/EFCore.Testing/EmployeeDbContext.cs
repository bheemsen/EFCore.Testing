using Microsoft.EntityFrameworkCore;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Authentication.ExtendedProtection.Configuration;
using System.Text;
using System.Threading.Tasks;


namespace EFCore.Testing
{
    public class EmployeeDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public bool IsUnitTest { get; set; }
        public EmployeeDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
            IsUnitTest = true;
        }
        public EmployeeDbContext()
        {

        }



        public DbSet<Employee> Employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!this.IsUnitTest)
                optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-143K4FV\SQLEXPRESS;Initial Catalog=TestDb;Integrated Security=True");
            // base.OnConfiguring(optionsBuilder);
        }
    }
}
