using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var db = new EmployeeDbContext();
                db.Employees.Add(new Employee()
                {
                    EmployeeId = 6,
                    EmployeeName = "Test"
                });
                db.SaveChanges();
                Console.WriteLine(1);
            }
            catch (Exception ex)
            {
            }
            Console.Read();
        }
    }
}

