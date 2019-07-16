using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class House
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var roofStars = 0;

            #region roof

            var roofRows = (n + 1) / 2;
            if (n%2 == 0)
            {
                roofStars = 2;
            }
            else
            {
                roofStars = 1;
            }

            for (int row = 1; row <= roofRows; row++)
            {
                var roofDashes = (n - roofStars) / 2;
                Console.Write(new string('-', roofDashes));
                Console.Write(new string('*', roofStars));
                Console.WriteLine(new string('-', roofDashes));

                roofStars += 2;
            }

            #endregion

            #region house body

            for (int bodyRows = 1; bodyRows <= n / 2; bodyRows++)
            {
                Console.Write('|');
                Console.Write(new string('*', n-2));
                Console.WriteLine('|');
            }

            #endregion
        }
    }
}
