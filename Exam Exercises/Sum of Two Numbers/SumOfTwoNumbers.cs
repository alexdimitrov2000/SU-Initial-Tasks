using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_Two_Numbers
{
    class SumOfTwoNumbers
    {
        static void Main(string[] args)
        {
            var start = int.Parse(Console.ReadLine());
            var end = int.Parse(Console.ReadLine());
            var magicNumber = int.Parse(Console.ReadLine());

            var combination = 0;
            var magicNumberFound = false;

            for (int i = start; i <= end; i++)
            {
                for (int g = start; g <= end; g++)
                {
                    combination++;
                    if (i + g == magicNumber)
                    {
                        magicNumberFound = true;
                        Console.WriteLine($"Combination N:{combination} ({i} + {g} = {magicNumber})");
                        break;
                    }
                }
                if (magicNumberFound == true)
                {
                    break;
                }
            }
            if (magicNumberFound == false)
            {
                Console.WriteLine($"{combination} combinations - neither equals {magicNumber}");
            }
        }
    }
}
