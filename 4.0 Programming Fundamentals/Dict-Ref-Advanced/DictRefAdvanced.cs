using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dict_Ref_Advanced
{
    class DictRefAdvanced
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> dictRef = new Dictionary<string, List<int>>();
            string input = Console.ReadLine();
            List<int> numbers = new List<int>();
            bool secPartIsList = false;

            while (input != "end")
            {
                string[] inputTokens = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string name = inputTokens[0];
                string secondPart = inputTokens[1];
                secPartIsList = false;

                if (secondPart[0] >= '0' && secondPart[0] <= '9')
                {
                    secPartIsList = true;
                    numbers = inputTokens[1].Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                }

                if (secPartIsList)
                {
                    if (!dictRef.ContainsKey(name))
                    {
                        dictRef.Add(name, new List<int>());
                    }
                    dictRef[name].AddRange(numbers);
                }
                else
                {
                    if (dictRef.ContainsKey(secondPart))
                    {
                        dictRef.Add(name, new List<int>());
                        dictRef[name].AddRange(dictRef[secondPart]);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var kvp in dictRef)
            {
                Console.WriteLine($"{kvp.Key} === {string.Join(", ", kvp.Value)}");
            }
        }
    }
}
