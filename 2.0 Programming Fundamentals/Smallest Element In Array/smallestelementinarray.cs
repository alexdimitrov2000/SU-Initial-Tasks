using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smallest_Element_In_array
{
    class SmallestElementInArray
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int smallestElement = int.MaxValue;
            int previousElement = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int currentElement = array[i];

                if (currentElement < smallestElement)
                {
                    smallestElement = currentElement;
                }
                previousElement = currentElement;
            }

            Console.WriteLine(smallestElement);
        }
    }
}
