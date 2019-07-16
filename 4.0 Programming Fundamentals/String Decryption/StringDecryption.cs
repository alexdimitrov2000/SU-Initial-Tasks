using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Decryption
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstLine = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int elementsToSkip = firstLine[0];
            int elementsToTake = firstLine[1];

            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] capitalLetters = numbers
                .Where(n => n >= 60 && n <= 90)
                .Skip(elementsToSkip)
                .Take(elementsToTake)
                .ToArray();

            char currentChar = default(char);
            string word = string.Empty;
            foreach (var element in capitalLetters)
            {
                currentChar = (char) element;

                word += currentChar;
            }

            Console.WriteLine(word);
        }
    }
}
