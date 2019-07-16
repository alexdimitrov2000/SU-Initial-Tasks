using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dollar_Triangle
{
    class DollarTriangle
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int rows = 1; rows <= n; rows++)
            {
                for (int i = 1; i <= rows; i++)
                {
                    Console.Write("$");    
                }
                Console.WriteLine();
            }
        }
    }
}
