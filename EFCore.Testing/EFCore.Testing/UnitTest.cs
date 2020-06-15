using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Testing
{
    [TestClass]
    public class UnitTest
    {

        [TestMethod]
        public void TestEmp()
        {
            string dbName = Guid.NewGuid().ToString();
            DbContextOptions<EmployeeDbContext> options = new DbContextOptionsBuilder<EmployeeDbContext>()
                            .UseInMemoryDatabase(databaseName: dbName).Options;

            using (EmployeeDbContext dbContext = new EmployeeDbContext(options))
            {
                var employees = new List<Employee>()
                {
                    new Employee(){EmployeeId=1,EmployeeName="Test1"},
                    new Employee(){EmployeeId=2,EmployeeName="Test2"},
                    new Employee(){EmployeeId=3,EmployeeName="Test3"}
                };

                dbContext.Employees.AddRange(employees);
                dbContext.SaveChanges();

                Assert.IsTrue(dbContext.Employees.FirstOrDefault(x => x.EmployeeId == 1).EmployeeName == "Test1");
            }

        }
    }
}
