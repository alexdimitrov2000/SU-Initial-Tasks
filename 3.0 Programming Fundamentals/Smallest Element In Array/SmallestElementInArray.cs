using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smallest_Element_In_Array
{
    class SmallestElementInArray
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int minElementValue = int.MaxValue;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < minElementValue)
                {
                    minElementValue = list[i];
                }
            }

            Console.WriteLine(minElementValue);
        }
    }
}
