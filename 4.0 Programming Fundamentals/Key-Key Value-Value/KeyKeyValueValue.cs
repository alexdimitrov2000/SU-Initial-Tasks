using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Key_Key_Value_Value
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> kvpToPrint = new Dictionary<string, List<string>>();
            string keyToFind = Console.ReadLine();
            string valueToFind = Console.ReadLine();
            int lines = int.Parse(Console.ReadLine());
            string currentKey = string.Empty;
            List<string> currentValues = new List<string>();

            for (int i = 0; i < lines; i++)
            {
                string[] input = Console.ReadLine().Split(new string[] { " => " }
                    , StringSplitOptions.RemoveEmptyEntries);
                currentKey = input[0];
                currentValues = input[1].Split(';').ToList();

                if (currentKey.Contains(keyToFind))
                {
                    if (!kvpToPrint.ContainsKey(currentKey))
                    {
                        kvpToPrint.Add(currentKey, new List<string>());
                    }

                    for (int j = 0; j < currentValues.Count; j++)
                    {
                        if (currentValues[j].Contains(valueToFind))
                        {
                            kvpToPrint[currentKey].Add(currentValues[j]);
                        }
                    }
                }
            }

            foreach (var kvPair in kvpToPrint)
            {
                Console.WriteLine($"{kvPair.Key}:");
                foreach (var value in kvPair.Value)
                {
                    Console.WriteLine($"-{value}");
                }
            }
        }
    }
}
