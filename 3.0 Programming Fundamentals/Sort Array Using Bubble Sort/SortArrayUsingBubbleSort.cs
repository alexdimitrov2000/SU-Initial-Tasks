using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Array_Using_Bubble_Sort
{
    class SortArrayUsingBubbleSort
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            list.Sort();

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
