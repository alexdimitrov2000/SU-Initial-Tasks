using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply_An_Array_Of_Doubles
{
    class MultiplyAnArrayOfDoubles
    {
        static void Main(string[] args)
        {
            double[] array = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double mnojitel = double.Parse(Console.ReadLine());

            double product = 0.0;

            for (int i = 0; i < array.Length; i++)
            {
                product = 0;
                product += array[i] * mnojitel;
                Console.Write($"{product} ");
            }
            Console.WriteLine();
        }
    }
}
