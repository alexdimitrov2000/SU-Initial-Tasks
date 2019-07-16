using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tests_only
{
    class tests
    {
        static void Main(string[] args)
        {
            string input = "OneTwoThree";

            // Get first three characters.
            string sub = input.Substring(6, 3);
            Console.WriteLine("Substring: {0}", sub);

        }
    }
}
