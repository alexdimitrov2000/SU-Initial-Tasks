using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stop_Number
{
    class StopNumber
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var s = int.Parse(Console.ReadLine());

            var firstLimit = 0 <= n && n < m && m<=10000 ;
            var secondLimit = n <= s && s <= m;

            if (!(firstLimit))
            {
                Console.WriteLine("Error");
            }
            else
            {
                for (int i = m; i >= n; i--)
                {
                    if (i % 2 == 0 && i % 3 == 0)
                    {
                        if (i == s)
                        {
                            break;
                        }
                        else
                        {
                            Console.Write(i + " ");
                        }
                    }
                }
            }
        }
    }
}
