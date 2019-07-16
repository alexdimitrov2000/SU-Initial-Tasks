using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_Element_In_Array
{
    class LargestElementInArray
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int givenElement = int.Parse(Console.ReadLine());
            int numberOfGivenElementFound = 0;


            for (int i = 0; i < array.Length; i++)
            {
                int currentElement = array[i];

                if (currentElement == givenElement)
                {
                    numberOfGivenElementFound++;
                }
            }

            Console.WriteLine(numberOfGivenElementFound);
        }
    }
}
