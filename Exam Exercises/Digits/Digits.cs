using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digits
{
    class Digits
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var firstDigit = n / 100;
            var secondDigit = n / 10 % 10;
            var thirdDigit = n % 10;
            var newNumber = 0;

            var rows = firstDigit + secondDigit;
            var columns = firstDigit + thirdDigit;

            for (int row = 1; row <= rows; row++)
            {
                for (int column = 1; column <= columns; column++)
                {
                    if (n % 5 == 0)
                    {
                        newNumber = n - firstDigit;
                    }
                    else if (n % 3 == 0)
                    {
                        newNumber = n - secondDigit;
                    }
                    else
                    {
                        newNumber = n + thirdDigit;
                    }
                    n = newNumber;
                    Console.Write(newNumber + " ");
                }
                    Console.WriteLine();
            }
            
        }
    }
}
