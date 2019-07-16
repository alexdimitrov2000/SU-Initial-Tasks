using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rocket
{
    class Rocket
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var length = 3 * n;
            var dots = 0;
            var freeSpace = 0;
            var slashes = 0;

            #region first part

            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('.', (length - freeSpace - 2) / 2));
                Console.Write("/");
                Console.Write(new string(' ', freeSpace));
                Console.Write("\\");
                Console.WriteLine(new string('.', (length - freeSpace - 2) / 2));
                freeSpace += 2;
            }
            dots = n / 2;
            Console.Write(new string('.', dots));
            Console.Write(new string('*', length - 2 * dots));
            Console.WriteLine(new string('.', dots));

            #endregion

            #region middle

            for (int i = 1; i <= 2 * n; i++)
            {
                dots = n / 2;
                Console.Write(new string('.', dots));
                Console.Write("|");
                Console.Write(new string('\\', length - 2 * dots - 2));
                Console.Write("|");
                Console.WriteLine(new string('.', dots));
            }

            #endregion

            #region end

                dots = n / 2;
            for (int i = 1; i <= n / 2; i++)
            {
                Console.Write(new string('.', dots));
                Console.Write("/");
                Console.Write(new string('*', length - 2 * dots - 2));
                Console.Write("\\");
                Console.WriteLine(new string('.', dots));
                dots--;
            }

            #endregion
        }
    }
}
