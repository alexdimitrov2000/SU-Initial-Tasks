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
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            int negativeNumbers = 0;
            int previousElement = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                int currentElement = array[i];

                if (currentElement < 0)
                {
                    negativeNumbers++;
                }
            }

            Console.WriteLine(negativeNumbers);
        }
    }
}
