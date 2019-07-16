using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var numberOfStarsAtFirst = 0;
            var numberOfDashes = 0;

            if (n == 1 && n == 2)
            {
                Console.WriteLine(new string('*', n));
            }
            else
            {
                if (n % 2 == 0)
                {
                    numberOfStarsAtFirst = 2;
                }
                else
                {
                    numberOfStarsAtFirst = 1;
                }

                #region first line

                Console.Write(new string('-', (n - numberOfStarsAtFirst) / 2));
                Console.Write(new string('*', numberOfStarsAtFirst));
                Console.WriteLine(new string('-', (n - numberOfStarsAtFirst) / 2));

                #endregion

                #region middle

                var dashesInMiddle = 0;
                var dashesInEnd = 0;
                if (n % 2 == 0)
                {
                    dashesInMiddle = 2;
                }
                else
                {
                    dashesInMiddle = 1;
                }

                var rowsBeforeMid = (n - 1) / 2;
                for (int i = 0; i < rowsBeforeMid; i++)
                {
                    dashesInEnd = (n - 2 - dashesInMiddle) / 2;
                    Console.Write(new string('-', dashesInEnd));
                    Console.Write('*');
                    Console.Write(new string('-', dashesInMiddle));
                    Console.Write('*');
                    Console.WriteLine(new string('-', dashesInEnd));

                    dashesInMiddle += 2;
                }

                var rowsAfterMid = rowsBeforeMid - 1;
                dashesInMiddle -= 2;
                for (int i = rowsAfterMid - 1; i >= 0; i--)
                {
                    dashesInMiddle -= 2;
                    dashesInEnd = (n - 2 - dashesInMiddle) / 2;
                    Console.Write(new string('-', dashesInEnd));
                    Console.Write('*');
                    Console.Write(new string('-', dashesInMiddle));
                    Console.Write('*');
                    Console.WriteLine(new string('-', dashesInEnd));
                }

                #endregion

                #region last Line

                Console.Write(new string('-', (n - numberOfStarsAtFirst) / 2));
                Console.Write(new string('*', numberOfStarsAtFirst));
                Console.WriteLine(new string('-', (n - numberOfStarsAtFirst) / 2));

                #endregion
            }
        }
    }
}
