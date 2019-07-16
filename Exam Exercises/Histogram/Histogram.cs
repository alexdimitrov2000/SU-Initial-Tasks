using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Division
{
    class Division
    {
        static void Main(string[] args)
        {
            //  < 200
            //  200 … 399
            //  400 … 599
            //  600 … 799
            //  ≥ 800

            var n = int.Parse(Console.ReadLine());
            var numbersUnder200 = 0.0;
            var numbersBetween200and399 = 0.0;
            var numbersBetween400and599 = 0.0;
            var numbersBetween600and799 = 0.0;
            var numbersHigherThan800 = 0.0;

            for (int i = 1; i <= n; i++)
            {
                var numbersToCheck = int.Parse(Console.ReadLine());

                if (numbersToCheck < 200)
                {
                    numbersUnder200++;
                }

                if (numbersToCheck >= 200 && numbersToCheck <= 399)
                {
                    numbersBetween200and399++;
                }

                if (numbersToCheck >= 400 && numbersToCheck <= 599)
                {
                    numbersBetween400and599++;
                }
                if (numbersToCheck >= 600 && numbersToCheck <= 799)
                {
                    numbersBetween600and799++;
                }
                if (numbersToCheck >= 800)
                {
                    numbersHigherThan800++;
                }
            }
            var p1 = numbersUnder200 / n * 100;
            var p2 = numbersBetween200and399 / n * 100;
            var p3 = numbersBetween400and599 / n * 100;
            var p4 = numbersBetween600and799 / n * 100;
            var p5 = numbersHigherThan800 / n * 100;


            Console.WriteLine($"{p1:F2}%");
            Console.WriteLine($"{p2:F2}%");
            Console.WriteLine($"{p3:F2}%");
            Console.WriteLine($"{p4:F2}%");
            Console.WriteLine($"{p5:F2}%");
        }
    }
}
