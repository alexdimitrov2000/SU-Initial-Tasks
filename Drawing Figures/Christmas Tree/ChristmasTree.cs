using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_Tree
{
    class ChristmasTree
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            if (!(n >= 1 && n <= 100))
            {
                Console.WriteLine("Error");
            }

            for (int rows = 0; rows <= n; rows++)
            {
                Console.Write(new string(' ', n - rows));
                Console.Write(new string('*', rows));
                Console.Write(" | ");
                Console.WriteLine(new string('*', rows));
            }  
        }
    }
}
