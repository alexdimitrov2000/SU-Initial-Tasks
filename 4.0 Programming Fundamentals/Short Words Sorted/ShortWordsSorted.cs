using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Short_Words_Sorted
{
    class ShortWordsSorted
    {
        static void Main(string[] args)
        {
            char[] delimiters = ".,:;()[]\"'\\/!? ".ToCharArray();

            string[] text = Console.ReadLine()
                .ToLower()
                .Split(delimiters, StringSplitOptions.RemoveEmptyEntries)
                .Distinct()
                .Where(w => w.Length < 5)
                .OrderBy(w => w)
                .ToArray();

            Console.WriteLine(string.Join(", ", text));
        }
    }
}
