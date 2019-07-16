using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Occurrences_of_Larger_Numbers_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double p = double.Parse(Console.ReadLine());
            int numbersBiggerThanP = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (p < array[i])
                {
                    numbersBiggerThanP++;
                }
            }
            Console.WriteLine(numbersBiggerThanP);
        }
    }
}
