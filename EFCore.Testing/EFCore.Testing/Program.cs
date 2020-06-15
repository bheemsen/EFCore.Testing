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
                var db = new TestDbContext();
                db.Employees.Add(new Employee()
                {
                    EmployeeId = 2,
                    EmployeeName = "Dhruv Sen"
                });
                db.SaveChanges();
                Console.WriteLine(1);
            }
            catch(Exception ex) 
            {
            }
            Console.Read();
        }
    }
}
