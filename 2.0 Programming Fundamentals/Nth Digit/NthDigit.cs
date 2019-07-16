using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nth_Digit
{
    class NthDigit
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine(FindNthDigit(number, index));
        }

        static long FindNthDigit(long number, int index)
        {
            int currentIndex = 1;

            while (number != 0)
            {
                if (currentIndex == index)
                {
                   return number %= 10;
                }
                number /= 10;
                currentIndex++;
            }

            return number % 10;
        }
    }
}
