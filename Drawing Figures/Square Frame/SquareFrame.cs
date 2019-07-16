using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Frame
{
    class SquareFrame
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.Write("+ ");
            for (int minuses = 0; minuses < n-2; minuses++)
            {
                Console.Write("- ");
            }
            Console.WriteLine("+ ");

            for (int mid = 0; mid < n - 2; mid++)
            {
                Console.Write("| ");
                for (int minuses = 0; minuses <  n - 2; minuses++)
                {
                    Console.Write("- ");
                }
                Console.WriteLine("| ");
            }

            Console.Write("+ ");
            for (int minuses = 0; minuses < n - 2; minuses++)
            {
                Console.Write("- ");
            }
            Console.WriteLine("+ ");
        }
    }
}
