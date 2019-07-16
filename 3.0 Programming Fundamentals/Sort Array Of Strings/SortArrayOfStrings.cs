using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Array_Of_Strings
{
    class SortArrayOfStrings
    {
        static string[] array;
        static void Main(string[] args)
        {
            array = Console.ReadLine().Split(' ').ToArray();
            bool swapped = false;
            do
            {
                swapped = false;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (string.Compare(array[i], array[i + 1]) == 1)
                    {
                        BubbleSorting(i);
                        swapped = true;
                    }
                }
            } while (swapped);

            Console.WriteLine(string.Join(" ", array));
        }

        static void BubbleSorting(int index)
        {
            string temp = array[index];
            array[index] = array[index + 1];
            array[index + 1] = temp;
        }
    }
}
