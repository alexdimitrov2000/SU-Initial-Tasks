using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Special_Numbers
{
    class SpecialNumbers
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var specialNumber = 0;        

            for (int i = 1; i <= 9; i++)
            {
                for (int g = 1; g <= 9; g++)
                {
                    for (int h = 1; h <= 9; h++)
                    {
                        for (int j = 1; j <= 9; j++)
                        {
                            if ((n % i == 0) && (n % g == 0) && (n % h == 0) && (n % j == 0))
                            {
                                Console.Write($"{i}{g}{h}{j} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
