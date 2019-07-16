using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increasing_Sequence_of_Elements
{
    class IncreasingSequenceOfElements
    {
        static void Main(string[] args)
        {
            double[] array = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double previousElement = 0.0;
            bool smallerThanThePrevious = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > previousElement)
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

                previousElement = array[i];
            }

            if (smallerThanThePrevious == false)
            {
                Console.WriteLine("Yes");
            }
        }
    }
}
