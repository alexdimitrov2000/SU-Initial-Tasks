using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Of_Odd_Numbers_In_Array
{
    class CountOfOddNumbersInArray
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int numberOfOddNumbers = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    numberOfOddNumbers++;
                }
            }
            Console.WriteLine(numberOfOddNumbers);
        }
    }
}
