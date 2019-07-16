using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Char_Rotation
{
    class CharRotation
    {
        static void Main(string[] args)
        {
            string firstArray = Console.ReadLine();
            char[] firstCharArray = firstArray.ToCharArray();
            int[] secondArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            char charSymbolFromArray;
            int charSymbolCode;
            int codeForString;
            char letterForTheString;
            string finalWord = string.Empty;

            for (int i = 0; i < firstArray.Length; i++)
            {
                charSymbolFromArray = firstCharArray[i];
                charSymbolCode = (int)charSymbolFromArray;

                if (secondArray[i] % 2 == 0)
                {
                    codeForString = charSymbolCode - secondArray[i];
                }
                else
                {
                    codeForString = charSymbolCode + secondArray[i];
                }

                letterForTheString = (char) codeForString;

                finalWord += letterForTheString;
            }

            Console.WriteLine(finalWord);
        }
    }
}
