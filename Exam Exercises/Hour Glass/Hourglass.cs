using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hour_Glass
{
    class Hourglass
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var size = 2 * n + 1;

            var dots = 0;
            var kliomba = 0;
            var wallStars = 0;
            var space = 0;

            #region before middle
            Console.WriteLine(new string('*', size));
            Console.Write(".");
            Console.Write("*");
            Console.Write(new string(' ', size - 4));
            Console.Write("*");
            Console.WriteLine(".");

            for (int i = 1; i < n - 1; i++)
            {
                dots = i + 1;
                kliomba = size - (dots * 2) - 2;
                Console.Write(new string('.', dots));
                Console.Write("*");
                Console.Write(new string('@', kliomba));
                Console.Write("*");
                Console.WriteLine(new string('.', dots));
            }

            Console.Write(new string('.', n));
            Console.Write("*");
            Console.WriteLine(new string('.', n));
            #endregion

            #region after middle
            Console.Write(new string('.', n - 1));
            Console.Write("*");
            Console.Write("@");
            Console.Write("*");
            Console.WriteLine(new string('.', n - 1));
            for (int i = n - 2; i > 1; i--)
            {
                dots = i;
                space = (size - (dots * 2 + 3)) / 2;
                Console.Write(new string('.', dots));
                Console.Write("*");
                Console.Write(new string(' ', space));
                Console.Write("@");
                Console.Write(new string(' ', space));
                Console.Write("*");
                Console.WriteLine(new string('.', dots));
            }
            Console.Write(".");
            Console.Write("*");
            Console.Write(new string('@', size - 4));
            Console.Write("*");
            Console.WriteLine(".");
            Console.WriteLine(new string('*', size));
            #endregion
        }
    }
}
