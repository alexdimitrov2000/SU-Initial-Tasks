using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letter_Repetition
{
    class LetterRepetition
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();

            string input = Console.ReadLine();
            char character = default(char);
            int count = 0;

            for (int i = 0; i < input.Length; i++)
            {
                character = input[i];
                if (!dict.ContainsKey(character))
                {
                    dict.Add(character, count);
                }
                dict[input[i]]++;
            }

            foreach (KeyValuePair<char, int> item in dict)
            {
                Console.WriteLine("{0} -> {1}",
                    item.Key,
                    item.Value);
            }
        }
    }
}
