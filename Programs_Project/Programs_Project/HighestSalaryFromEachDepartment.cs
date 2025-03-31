using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs_Project
{
    public class EmployeesWithDept
    {
        public int Emp_id { get; set; }
        public string Emp_name { get; set; }
        public decimal Emp_salary { get; set; }
        public int Emp_dept { get; set; }
    }
    public class HighestSalaryFromEachDepartment
    {
        public static void Main()
        {
            List<EmployeesWithDept> emplist = new List<EmployeesWithDept> {
        new EmployeesWithDept{ Emp_id = 1, Emp_name = "Brunda", Emp_salary = 1000,Emp_dept = 1 },
        new EmployeesWithDept{ Emp_id = 2, Emp_name = "Divya", Emp_salary = 2000,Emp_dept = 2},
        new EmployeesWithDept{ Emp_id = 3, Emp_name = "Shwetha", Emp_salary = 900 ,Emp_dept = 2},
        new EmployeesWithDept{ Emp_id = 4, Emp_name = "Swathi", Emp_salary = 1000,Emp_dept = 1},
        new EmployeesWithDept{ Emp_id = 5, Emp_name = "Anil", Emp_salary = 1300,Emp_dept = 3},
        new EmployeesWithDept{ Emp_id = 6, Emp_name = "Anu", Emp_salary = 10000,Emp_dept = 4 },
        new EmployeesWithDept{ Emp_id = 7, Emp_name = "Anu", Emp_salary = 2000,Emp_dept = 3}
        };

            var data = emplist.GroupBy(x => x.Emp_dept).Select(e => new
            {
                Emp_dept = e.Key,
                Max_slary = e.Max(x => x.Emp_salary)
            });

            foreach (var item in data)
            {
                Console.WriteLine($"Department: {item.Emp_dept}, Highest Salary: {item.Max_slary}");
            }
        }
    }
}
