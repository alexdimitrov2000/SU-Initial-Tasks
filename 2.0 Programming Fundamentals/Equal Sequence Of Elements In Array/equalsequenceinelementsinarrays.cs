using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Sequence_In_Elements_In_Arrays
{
    class EqualSequenceInElementsInArrays
    {
        static void Main(string[] args)
        {
            double[] array = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double previousElement = array[0];
            bool smallerThanThePrevious = false;

            for (int i = 0; i < array.Length; i++)
            {
                double currentElement = array[i];
                if (array[i] == previousElement)
                {
                    smallerThanThePrevious = false;
                }
                else
                {
                    smallerThanThePrevious = true;
                }

                if (smallerThanThePrevious)
                {
                    Console.WriteLine("No");
                    break;
                }
                previousElement = currentElement;
            }

            if (smallerThanThePrevious == false)
            {
                Console.WriteLine("Yes");
            }
        }
    }
}
