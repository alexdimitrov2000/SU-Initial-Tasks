using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_Sort
{
    class BubbleSort
    {
        static int[] intArray;
        static void Main(string[] args)
        {
            intArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool swapped = false;
            do
            {
                swapped = false;
                for (int i = 0; i < intArray.Length - 1; i++)
                {
                    if (intArray[i] > intArray[i + 1])
                    {
                        BubbleSorting(i);
                        swapped = true;
                    }
                }
            } while (swapped == true);

            Console.WriteLine(string.Join(" ", intArray));
        }

        static void BubbleSorting(int index)
        {
            if (intArray[index] > intArray[index + 1])
            {
                int temp = intArray[index];
                intArray[index] = intArray[index + 1];
                intArray[index + 1] = temp;
            }
        }
    }
}
