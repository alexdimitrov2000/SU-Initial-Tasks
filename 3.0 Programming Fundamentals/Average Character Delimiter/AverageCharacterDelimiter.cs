using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average_Character_Delimiter
{
    class AverageCharacterDelimiter
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ').ToArray();

            char[] characters = new char[]{};
            int totalCharactersSum = 0;
            int totalAsciiCharsSum = 0;

            for (int i = 0; i < words.Length; i++)
            {
                characters = words[i].ToCharArray();
                totalCharactersSum += characters.Length;

                for (int j = 0; j < characters.Length; j++)
                {
                    int asciiCode = (int) characters[j];
                    totalAsciiCharsSum += asciiCode;
                }
            }

            double result = 0.0;
            result = ((char)((double)totalAsciiCharsSum / (double)totalCharactersSum));

            string delimiter = ((char)result).ToString().ToUpper();

            Console.WriteLine(string.Join(delimiter, words));
        }
    }
}
