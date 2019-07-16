using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sun_Glasses
{
    class SunGlasses
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            if (!(n>=3 && n<=100))
            {
                Console.WriteLine("Error");
            }

            Console.Write(new string('*', 2 * n));
            Console.Write(new string (' ', n));
            Console.WriteLine(new string('*', 2 * n));
            
            for (int row = 0; row < n - 2; row++)
            {
                Console.Write("*");
                Console.Write(new string('/', 2 * n - 2));
                Console.Write("*");

                if (row == (n-1) / 2 - 1)
                {
                    Console.Write(new string('|', n));
                }
                else
                {
                    Console.Write(new string(' ', n));
                }

                Console.Write("*");
                Console.Write(new string('/', 2 * n - 2));
                Console.WriteLine("*");
            }           

            Console.Write(new string('*', 2 * n));
            Console.Write(new string(' ', n));
            Console.WriteLine(new string('*', 2 * n));
        }
    }
}
