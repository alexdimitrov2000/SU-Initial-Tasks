using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_3_Numbers
{
    class Largest3Numbers
    {
        static void Main(string[] args)
        {
            List<int> numbersList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            numbersList.Sort();
            numbersList.Reverse();
            Console.WriteLine(string.Join(" ", numbersList.Take(3)));
        }
    }
}
