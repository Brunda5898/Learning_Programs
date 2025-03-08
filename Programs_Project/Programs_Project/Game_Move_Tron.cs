using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Programs_Project
{
//    Like the game/movie Tron.Write a software program that can determine whether move sequences are valid.
//    Given a sequence of characters containing 'U', 'D', 'L', 'R' representing unit movements on an integer plane,
//    determine whether the path it takes is Valid, meaning that it never visits the same point more than once.Examples:

//"UULUL" → true 
//"UULDR" → false (visits 0,1 twice)

     //In graph moves reach same point again then return false else true.
    public class Game_Move_Tron
    {
        public static void Main()
        {
            Console.WriteLine("Enter moves sequence : ");
            string moves = Console.ReadLine().Trim().ToUpper();
            bool result = isValidPath(moves);
            Console.WriteLine(result);
        }

        public static bool isValidPath(string moves)
        {

            HashSet<(int, int)> visited = new HashSet<(int, int)>();
            int x = 0, y = 0;

            visited.Add((x, y));

            foreach(char move in moves)
            {
                switch(move)
                {
                    case 'U': x++; break;
                    case 'D': x--; break;
                    case 'R': y++; break;
                    case 'L': y--; break;
                    default: return false;
                }

                if(visited.Contains((x,y)))
                {
                    return false;
                }
                visited.Add((x,y));
            }
            return true;
        }
    }
}
