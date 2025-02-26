using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs_Project
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public decimal Salary { get; set; }
    }

    public class SumofSalaryUsingLinq
    {

        public static void Main()
        {
            // Sample Employee List
            List<Employee> employees = new List<Employee>
        {
            new Employee { EmpId = 1, EmpName = "Alice", Salary = 5000 },
            new Employee { EmpId = 2, EmpName = "Bob", Salary = 6000 },
            new Employee { EmpId = 1, EmpName = "Alice", Salary = 7000 }, // Duplicate EmpId (same employee)
            new Employee { EmpId = 3, EmpName = "Charlie", Salary = 5500 },
            new Employee { EmpId = 2, EmpName = "Bob", Salary = 4000 } // Duplicate EmpId (same employee)
        };

            // LINQ Query to Sum Salaries by EmpId & EmpName
            var result = employees
                .GroupBy(e => new { e.EmpId, e.EmpName }) // Group by EmpId & EmpName
                .Select(g => new
                {
                    EmpId = g.Key.EmpId,
                    EmpName = g.Key.EmpName,
                    TotalSalary = g.Sum(e => e.Salary) // Sum Salary for each group
                })
                .OrderBy(e => e.EmpId); // Sort by EmpId

            // Print the result
            foreach (var emp in result)
            {
                Console.WriteLine($"EmpId: {emp.EmpId}, EmpName: {emp.EmpName}, Total Salary: {emp.TotalSalary}");
            }
        }
    }
}
