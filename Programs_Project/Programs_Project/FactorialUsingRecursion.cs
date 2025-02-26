using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs_Project
{
    public class FactorialUsingRecursion
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter number to calculate factorial : ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int num))
            {
                long result = CalculateFactorialNumber(num);
                Console.WriteLine("Factorial output : " + result);
            }
            else
            {
                Console.WriteLine("Invalid Input!");
            }
        }

        public static long CalculateFactorialNumber(int num)
        {
            if (num == 0 || num == 1)
            {
                return 1;
            }

            return num * CalculateFactorialNumber(num - 1);

        }
    }
}
