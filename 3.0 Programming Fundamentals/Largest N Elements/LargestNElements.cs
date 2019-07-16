using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_N_Elements
{
    class LargestNElements
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int number = int.Parse(Console.ReadLine());

            list.Sort();

            List<int> finalList = new List<int>();

            for (int i = 0; i < number; i++)
            {
                finalList.Add(list[list.Count - i - 1]);
            }

            Console.WriteLine(string.Join(" ", finalList));
        }
    }
}
