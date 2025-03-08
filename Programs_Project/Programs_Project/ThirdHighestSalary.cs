using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs_Project
{
    public class Employees
    {
        public int Emp_id { get; set; }
        public string Emp_name { get; set; }
        public decimal Emp_salary { get; set; }
    }
    public class ThirdHighestSalary
    {
        public static void Main()
        {
            List<Employees> emplist = new List<Employees>
        {
            new Employees{ Emp_id = 1, Emp_name = "Brunda", Emp_salary = 1000},
            new Employees{ Emp_id = 2, Emp_name = "Divya", Emp_salary = 2000},
            new Employees{ Emp_id = 3, Emp_name = "Shwetha", Emp_salary = 900},
            new Employees{ Emp_id = 4, Emp_name = "Swathi", Emp_salary = 8000},
            new Employees{ Emp_id = 5, Emp_name = "Anil", Emp_salary = 1300},
            new Employees{ Emp_id = 6, Emp_name = "Anu", Emp_salary = 10000},
            new Employees{ Emp_id = 7, Emp_name = "Anu", Emp_salary = 2000}
        };

            //Employees details = new Employees();
            //var details = emplist.Select(x => new Employees { Emp_id = x.Emp_id, Emp_name = x.Emp_name, Emp_salary = x.Emp_salary }).GroupBy(x => x.Emp_salary).Distinct().Skip(2).FirstOrDefault();
            var groupedSalaries = emplist.GroupBy(x => x.Emp_salary).OrderByDescending(y=>y.Key).Skip(2).FirstOrDefault();
            if (groupedSalaries != null)
            {
                Console.WriteLine($"The 3rd highest salary is: {groupedSalaries.Key}");
                Console.WriteLine("Employees with this salary:");
                // To print employee list of same highest salary
                foreach (var emp1 in groupedSalaries)
                {
                    Console.WriteLine($"ID: {emp1.Emp_id}, Name: {emp1.Emp_name}, Salary: {emp1.Emp_salary}");
                }

                // print only one employee of highest salary
                var emp = groupedSalaries.FirstOrDefault();
               Console.WriteLine($"ID: {emp.Emp_id}, Name: {emp.Emp_name}, Salary: {emp.Emp_salary}");
            }
            else
            {
                Console.WriteLine("There is no 3rd highest salary.");
            }
        }
    }
}
