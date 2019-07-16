using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stop__draw_
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var dots = 0;
            var underscore = 2 * n - 1;
            var slashes = 0;

            #region first part
            Console.Write(new string('.', n + 1));
            Console.Write(new string('_', 2 * n + 1));
            Console.WriteLine(new string('.', n + 1));
            for (int i = n; i >= 1; i--)
            {
                dots = i;
                Console.Write(new string('.', dots));
                Console.Write("//");
                Console.Write(new string('_', underscore));
                Console.Write(@"\\");
                Console.WriteLine(new string('.', dots));
                underscore += 2;
            }

            #endregion

            #region middle

            Console.Write("//");
            Console.Write(new string('_', (underscore - 5) / 2));
            Console.Write("STOP!");
            Console.Write(new string('_', (underscore - 5) / 2));
            Console.WriteLine(@"\\");

            #endregion

            #region end

            for (int i = 0; i < n; i++)
            {
                dots = i;
                Console.Write(new string('.', dots));
                Console.Write(@"\\");
                Console.Write(new string('_', underscore));
                Console.Write("//");
                Console.WriteLine(new string('.', dots));
                underscore -= 2;
            }
            #endregion

            // not working :/
        }
    }
}
