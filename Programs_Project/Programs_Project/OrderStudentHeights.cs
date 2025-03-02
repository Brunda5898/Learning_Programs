using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs_Project
{
    //Student in a class are asked to stand in ascending order according to their heights for the annual class photograph.
    //Determine the number of students not currently standing in their correct positions.

    //Example : Height = [1,1,3,3,4,1]
    // The 3 stuents indicated in red at indices 2,4, and 5, are not in the right positions. The correct positions are [1,1,1,3,3,4]. Retuen 3
    public class OrderStudentHeights
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(Console.OpenStandardOutput());

            int heightCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> height = new List<int>();

            for (int i = 0; i < heightCount; i++)
            {
                int heightItem = Convert.ToInt32(Console.ReadLine().Trim());
                height.Add(heightItem);
            }

            int result = countStudents(height);

            textWriter.WriteLine(result);
            textWriter.Flush();
            textWriter.Close();
        }

        public static int countStudents(List<int> heights)
        {
            List<int> expected = new List<int>(heights);
            expected.Sort();

            int count = 0;
            for (int i = 0; i < heights.Count; i++)
            {
                if (heights[i] != expected[i])
                {
                    count++;
                }
            }

            return count;
        }
    }
}
