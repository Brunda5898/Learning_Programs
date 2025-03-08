using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs_Project
{
    public class Nth_Highest_Salary
    {
        public static void Main()
        {
            List<Employees> emp_list = new List<Employees> {
            new Employees{ Emp_id = 1, Emp_name = "Brunda", Emp_salary = 1000},
            new Employees{ Emp_id = 2, Emp_name = "Divya", Emp_salary = 2000},
            new Employees{ Emp_id = 3, Emp_name = "Shwetha", Emp_salary = 900},
            new Employees{ Emp_id = 4, Emp_name = "Swathi", Emp_salary = 8000},
            new Employees{ Emp_id = 5, Emp_name = "Anil", Emp_salary = 1300},
            new Employees{ Emp_id = 6, Emp_name = "Anu", Emp_salary = 10000},
            new Employees{ Emp_id = 7, Emp_name = "Anu", Emp_salary = 2000}
            };

            Console.WriteLine("Enter the value of N (Nth salary number) : ");
            int n;
            if(!int.TryParse(Console.ReadLine(), out n) || n<=0)
            {
                Console.WriteLine("Invalid input! Please enter valid positive number");
            }
            else
            {
                var Hightsalary = emp_list.GroupBy(x => x.Emp_salary).OrderByDescending(x => x.Key).Skip(n - 1).FirstOrDefault();
                var emp = Hightsalary.FirstOrDefault();
                Console.WriteLine("Emp_id: " + emp.Emp_id + ", Emp_name: " + emp.Emp_name + ", Emp_salary: " + emp.Emp_salary);
            }
            
        }


    }
}
