using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last_3_Consecutive_Equal_Strings
{
    class Last3ConsecutiveEqualStrings
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ').ToArray();

            string threeEqualStrings = string.Empty;
            int numberOfEquality = 0;
            bool thereAreEqualStrings = false;

            for (int i = 0; i < words.Length - 1; i++)
            {
                if (words[i] == words[i + 1])
                {
                    numberOfEquality++;

                    if (numberOfEquality == 2)
                    {
                        threeEqualStrings = $"{words[i]} {words[i]} {words[i]}";
                        numberOfEquality = 0;
                        thereAreEqualStrings = true;
                    }
                }
                else
                {
                    numberOfEquality = 0;
                }
            }

            if (thereAreEqualStrings)
            {
                Console.WriteLine(threeEqualStrings);
            }
        }
    }
}
