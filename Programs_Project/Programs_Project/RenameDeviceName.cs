using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Programs_Project
{
    //Create unique device names to be used in a residential loT (Internet of Things) system.
    //If a device name already exists in the system, an integer number is added at the end of the name to make it unique.
    //The integer added starts with 1 and is incremented by 1 for each new request of an existing device name.
    //Given a list of device name requests, process all requests and return an array of the corresponding unique device names.
    //Example
    //n = 6
    //devicenames = ['switch', tv', 'switch', 'tv,'switch', tv']
    //output = ['switch', tv', 'switch1', 'tv1,'switch2', tv2']
    public class RenameDeviceName
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(Console.OpenStandardOutput());

            int devicenamesCount = Convert.ToInt32(Console.ReadLine().Trim());
            List<string> devicenames = new List<string>();

            for (int i = 0; i < devicenamesCount; i++)
            {
                string devicenamesItem = Console.ReadLine();
                devicenames.Add(devicenamesItem);
            }

            List<string> result = deviceNamesSystem(devicenames);

            textWriter.WriteLine(string.Join("\n", result));
            textWriter.Flush();
            textWriter.Close();
        }

        public static List<string> deviceNamesSystem(List<string> deviceNames)
        {
            Dictionary<string, int> nameCount = new Dictionary<string, int>();
            List<string> uniqueNames = new List<string>();

            foreach (var name in deviceNames)
            {
                if (!nameCount.ContainsKey(name))
                {
                    nameCount[name] = 0;
                    uniqueNames.Add(name);
                }
                else
                {
                    nameCount[name]++;
                    string newName = name + nameCount[name];

                    while (nameCount.ContainsKey(newName))
                    {
                        nameCount[name]++;
                        newName = name + nameCount[name];
                    }

                    nameCount[newName] = 0;
                    uniqueNames.Add(newName);
                }
            }

            return uniqueNames;
        }
    }
}
