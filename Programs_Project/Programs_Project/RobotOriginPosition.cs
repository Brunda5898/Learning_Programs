using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Programs_Project
{
    public class RobotOriginPosition
    {
        public static void Main()
        {
            Console.WriteLine("Enter moves sequence : ");
            string input = Console.ReadLine().Trim().ToUpper();
            bool result = isStartPosition(input);
            Console.WriteLine(result);          

        }

        public static bool isStartPosition(string input)
        {
            int ud = 0, lr = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'U')
                {
                    ud++;
                }
                else if (input[i] == 'D')
                {
                    ud--;
                }
                else if (input[i] == 'L')
                {
                    lr++;
                }
                else if (input[i] == 'R')
                {
                    lr--;
                }
            }

            if (lr == 0 && ud == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
