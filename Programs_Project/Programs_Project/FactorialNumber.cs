using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs_Project
{
    public class FactorialNumber
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter required factorial num : ");
            var input = Console.ReadLine(); 

            if (int.TryParse(input, out int intValue))
            {
               // Console.WriteLine("Valid");
                int num = Convert.ToInt32(intValue);
                int result = 1;

                for (int i = 1; i <= num; i++)
                {
                    result = result * i;
                }
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Invalid Input!");
            }

        }

    }
}
