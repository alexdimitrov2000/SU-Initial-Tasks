using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_of_Capital_Letters_in_Array
{
    class CountOfCapitalLettersInArray
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(' ').ToArray();
            int numberOfCapitalLetters = 0;
            string currentWord = string.Empty;
            char letter = default(char);

            for (int i = 0; i < text.Length; i++)
            {
                currentWord = text[i];
                if (currentWord.Length == 1)
                {
                    letter = char.Parse(currentWord);
                    if (letter >= 'A' && letter <= 'Z')
                    {
                        numberOfCapitalLetters++;
                    }
                }
            }

            Console.WriteLine(numberOfCapitalLetters);
        }
    }
}
