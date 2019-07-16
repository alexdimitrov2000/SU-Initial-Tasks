using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decode_Radio_Frequences
{
    class DecodeRadioFrequences
    {
        static void Main(string[] args)
        {
            string[] frequences = Console.ReadLine().Split(' ');

            string[] seperatedFrequences;
            int leftFreqInt = 0;
            int rightFreqInt = 0;
            List<char> word = new List<char>();
            char leftLetter = default(char);
            char rightLetter = default(char);

            for (int i = 0; i < frequences.Length; i++)
            {
                seperatedFrequences = frequences[i].Split('.').ToArray();
                leftFreqInt = int.Parse(seperatedFrequences[0]);
                rightFreqInt = int.Parse(seperatedFrequences[1]);

                leftLetter = (char)leftFreqInt;
                rightLetter = (char)rightFreqInt;

                if (leftFreqInt != 0)
                {
                    word.Insert(i, leftLetter);
                }
                if (rightFreqInt != 0)
                {
                    word.Insert(i + 1, rightLetter);
                }
            }

            Console.WriteLine(string.Join("", word));
        }
    }
}
