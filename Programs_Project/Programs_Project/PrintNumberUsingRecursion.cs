using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs_Project
{
    public class PrintNumberUsingRecursion
    {
        public static void Main(string[] args)
        {
            PrintNumber(1);
        }

        public static void PrintNumber(int number)
        {
            if(number > 10)
            {
                return;
            }

            Console.WriteLine(number);
            PrintNumber(number + 1);
        }
    }

    
}
