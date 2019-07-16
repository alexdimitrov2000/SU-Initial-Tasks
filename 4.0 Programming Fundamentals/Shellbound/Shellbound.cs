using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shellbound
{
    class Shellbound
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<int>> cityShells = new Dictionary<string, List<int>>();

            while (input != "Aggregate")
            {
                string[] inputTokens = input.Split(' ');
                string city = inputTokens[0];
                int shellSize = int.Parse(inputTokens[1]);

                if (!cityShells.ContainsKey(city))
                {
                    cityShells.Add(city, new List<int>());
                }
                if (!cityShells[city].Contains(shellSize))
                {
                    cityShells[city].Add(shellSize);
                }

                input = Console.ReadLine();
            }

            foreach (var cityShellPair in cityShells)
            {
                int sumOfShellSizes = cityShellPair.Value.Sum();
                int averageOfShellSizes = (int)cityShellPair.Value.Average();
                int giantShell = sumOfShellSizes - averageOfShellSizes;

                Console.WriteLine($"{cityShellPair.Key} -> {string.Join(", ", cityShellPair.Value)} ({giantShell})");
            }
        }
    }
}
