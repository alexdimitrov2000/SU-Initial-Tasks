using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min_Method
{
    class MinMethod
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int result = Math.Min(GetMin(firstNumber, secondNumber), thirdNumber);

            Console.WriteLine(result);
        }

        static int GetMin(int a, int b)
        {
            int minimum = Math.Min(a, b);

            return minimum;
        }
    }
}
