using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            #region firstLine

            if (n % 2 == 0)
            {
                var numberOfStars = 2;
                var numberOfDashes = (n - numberOfStars) / 2;
                Console.Write(new string('-', numberOfDashes));
                Console.Write(new string('*', numberOfStars));
                Console.WriteLine(new string('-', numberOfDashes));
            }
            else
            {
                var numberOfStars = 1;
                var numberOfDashes = (n - numberOfStars) / 2;
                Console.Write(new string('-', numberOfDashes));
                Console.Write(new string('*', numberOfStars));
                Console.WriteLine(new string('-', numberOfDashes));
            }

            #endregion

            var numberOfDashesInMiddle = 0;
            if (n % 2 == 0)
            {
                numberOfDashesInMiddle = 2;
            }
            else
            {
                numberOfDashesInMiddle = 1;
            }

            var numberOfRows = (n - 1) / 2;
            for (int i = 0; i < numberOfRows; i++)
            {
                var numberOfDashesInEnd = (n - 2 - numberOfDashesInMiddle) / 2;
                Console.Write(new string('-', numberOfDashesInEnd));
                Console.Write('*');
                Console.Write(new string('-', numberOfDashesInMiddle));
                Console.Write('*');
                Console.WriteLine(new string('-', numberOfDashesInEnd));
                numberOfDashesInMiddle += 2;
            }

            numberOfRows--;
            numberOfDashesInMiddle -= 2;
            for (int i = numberOfRows - 1; i >= 0; i--)
            {
                numberOfDashesInMiddle -= 2;
                var numberOfDashesInEnd = (n - 2 - numberOfDashesInMiddle) / 2;
                Console.Write(new string('-', numberOfDashesInEnd));
                Console.Write('*');
                Console.Write(new string('-', numberOfDashesInMiddle));
                Console.Write('*');
                Console.WriteLine(new string('-', numberOfDashesInEnd));

            }

            #region last line

            if (n % 2 == 0)
            {
                var numberOfStars = 2;
                var numberOfDashes = (n - numberOfStars) / 2;
                Console.Write(new string('-', numberOfDashes));
                Console.Write(new string('*', numberOfStars));
                Console.WriteLine(new string('-', numberOfDashes));
            }
            else
            {
                var numberOfStars = 1;
                var numberOfDashes = (n - numberOfStars) / 2;
                Console.Write(new string('-', numberOfDashes));
                Console.Write(new string('*', numberOfStars));
                Console.WriteLine(new string('-', numberOfDashes));
            }

            #endregion
        }
    }
}