using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string command = Console.ReadLine();

            double averageNumber = inputNumbers.Average();

            List<int> newList = inputNumbers
                .Where(n => n >= averageNumber)
                .OrderBy(n => n)
                .ToList();

            if (command == "Max")
            {
                Console.WriteLine(newList.Max());
            }
            else if (command == "Min")
            {
                Console.WriteLine(newList.Min());
            }
            else if (command == "All")
            {
                Console.WriteLine(string.Join(" ", newList));
            }
        }
    }
}
