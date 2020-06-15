using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore.Testing
{
    [Table("Employee")]
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
    }
}