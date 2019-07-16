using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tests
{
    class tests
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(' ').ToList();

            var list2 = list.OrderBy(w => w.Length);

            foreach (var word in list2)
            {
                Console.WriteLine(word);
            }
        }
    }
}
