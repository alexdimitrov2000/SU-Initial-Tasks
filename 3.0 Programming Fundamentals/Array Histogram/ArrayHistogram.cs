using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Histogram
{
    class ArrayHistogram
    {
        static List<string> result;
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ').ToArray();
            string currentWord = string.Empty;
            List<string> words = new List<string>();
            List<int> repeatedWords = new List<int>();
            result = new List<string>();
            int repeatedTimes = 0;

            for (int i = 0; i < array.Length; i++)
            {
                currentWord = array[i];
                if (!(words.Contains(currentWord)))
                {
                    words.Add(currentWord);
                }
            }

            for (int i = 0; i < words.Count; i++)
            {
                repeatedTimes = 0;
                for (int j = 0; j < array.Length; j++)
                {
                    if (words[i] == array[j])
                    {
                        repeatedTimes++;
                    }
                }
                repeatedWords.Insert(i, repeatedTimes);
            }

            for (int i = 0; i < repeatedWords.Count - 1; i++)
            {
                int j = i + 1;
                while (j > 0)
                {
                    if (repeatedWords[j - 1] < repeatedWords[j])
                    {
                        int temp = repeatedWords[j];
                        repeatedWords[j] = repeatedWords[j - 1];
                        repeatedWords[j - 1] = temp;


                        string tempWord = words[j];
                        words[j] = words[j - 1];
                        words[j - 1] = tempWord;
                    }
                    j--;
                }
            }
            for (int h = 0; h < words.Count; h++)
            {
                Console.WriteLine($"{words[h]} -> {repeatedWords[h]} times ({(((double)repeatedWords[h] / (double)array.Length) * 100.00):F2}%)");
            }
        }

        static void BubbleSorting(int index)
        {
            string temp = result[index];
            result[index] = result[index + 1];
            result[index + 1] = temp;
        }
    }
}
