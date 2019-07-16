using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Combination
{
    class MaxCombination
    {
        static void Main(string[] args)
        {
            var start = int.Parse(Console.ReadLine());
            var end = int.Parse(Console.ReadLine());
            var maxNumberCombination = int.Parse(Console.ReadLine());

            var combination = 0;

            for (int i = start; i <= end; i++)
            {
                for (int g = start; g <= end; g++)
                {
                    combination++;
                    Console.Write($"<{i}-{g}>");
                    if (combination == maxNumberCombination)
                    {
                        break;
                    }
                }
                if (combination == maxNumberCombination)
                {
                    Console.WriteLine();
                    break;
                }
            }
        }
    }
}
