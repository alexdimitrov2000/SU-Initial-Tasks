using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sino_The_Walker
{
    class SinoTheWalker
    {
        static void Main(string[] args)
        {
            TimeSpan time = TimeSpan.Parse(Console.ReadLine());
            int step = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            long stepTime = step * seconds;
            TimeSpan result = TimeSpan.FromSeconds(stepTime);

            TimeSpan sumTime = time + result;

            Console.WriteLine("Time Arrival: {0:hh\\:mm\\:ss}", sumTime);
        }
    }
}
