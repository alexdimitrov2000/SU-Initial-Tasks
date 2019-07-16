using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Repeater
{
    class StringRepeater
    {
        static void Main(string[] args)
        {
            string stringToPrint = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            RepeatString(stringToPrint, count);
        }

        static string RepeatString(string stringToPrint, int count)
        {
            string repeatedString = string.Empty;

            for (int i = 0; i < count; i++)
            {
                Console.Write(stringToPrint);
            }
            Console.WriteLine();

            return repeatedString;
        }
    }
}
