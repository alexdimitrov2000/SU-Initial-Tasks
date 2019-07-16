using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw_Fort
{
    class DrawFort
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var columnMiiddle = n / 2;
            var betweenColumns = 2 * (n - n / 2) - 4;

            #region first line

            Console.Write('/');
            Console.Write(new string('^', columnMiiddle));
            Console.Write("\\");
            if (n > 4)
            {
                Console.Write(new string('_', betweenColumns));
            }
            Console.Write('/');
            Console.Write(new string('^', columnMiiddle));
            Console.WriteLine("\\");
            #endregion

            #region middle
            var midWalls = n - 2;
            var spaceBetweenWalls = 2 * n - 2;

            for (int rows = 0; rows < midWalls - 1; rows++)
            {
                Console.Write('|');
                Console.Write(new string(' ', spaceBetweenWalls));
                Console.WriteLine('|');
            }

            if (n > 4)
            {
                Console.Write('|');
                Console.Write(new string(' ', columnMiiddle + 1));
                Console.Write(new string('_', betweenColumns));
                Console.Write(new string(' ', columnMiiddle + 1));
                Console.WriteLine('|');
            }
            else
            {
                Console.Write('|');
                Console.Write(new string(' ', spaceBetweenWalls));
                Console.WriteLine('|');
            }

            #endregion

            #region last line

            Console.Write('\\');
            Console.Write(new string('_', columnMiiddle));
            Console.Write("/");
            if (n > 4)
            {
                Console.Write(new string(' ', betweenColumns));
            }
            Console.Write('\\');
            Console.Write(new string('_', columnMiiddle));
            Console.WriteLine("/");

            #endregion
        }
    }
}
