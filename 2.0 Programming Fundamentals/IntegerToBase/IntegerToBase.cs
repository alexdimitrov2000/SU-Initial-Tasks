using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerToBase
{
    class IntegerToBase
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            int toBase = int.Parse(Console.ReadLine());

            Console.WriteLine(IntToBase(number, toBase));
        }

        static string IntToBase(long number, int toBase)
        {
            string result = string.Empty;
            while (number != 0)
            {
                int remainder = (int)number % toBase;
                
                result = remainder + result;
                number /= toBase;
            }
            return result;
        }
    }
}
