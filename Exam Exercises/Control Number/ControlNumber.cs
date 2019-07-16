using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Number
{
    class ControlNumber
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var controlNumber = int.Parse(Console.ReadLine());

            var sum = 0;
            var move = 0;
            var success = false;

            for (int i = 1; i <= n; i++)
            {
                for (int g = m; g >= 1; g--)
                {
                    move++;
                    sum = sum + 2 * i + 3 * g;

                    if (sum >= controlNumber)
                    {
                        success = true;
                        break;
                    }
                }
                if (success == true)
                {
                    Console.WriteLine($"{move} moves");
                    Console.WriteLine($"Score: {sum} >= {controlNumber}");
                    break;
                }
            }
            if (success == false)
            {
                Console.WriteLine($"{move} moves");
            }
        }
    }
}
