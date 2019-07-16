using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Encryption
{
    class StringEncryption
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string encryptedMessage = string.Empty;

            for (int i = 0; i < n; i++)
            {
                char letter = char.Parse(Console.ReadLine());

                encryptedMessage += Encrypt(letter);
            }
            Console.WriteLine(encryptedMessage);
        }

        static string Encrypt(char letter)
        {
            int asciiCode = (int)letter;
            int firstDigit = 0;
            int lastDigit = 0;

            if (asciiCode < 100)
            {
                 firstDigit = asciiCode / 10;
                 lastDigit = asciiCode % 10;
            }    
            else 
            {    
                 firstDigit = asciiCode / 100;
                 lastDigit = asciiCode % 10;
            }

            int middleNumbers = Convert.ToInt32(string.Format("{0}{1}", firstDigit, lastDigit));

            int start = asciiCode + lastDigit;
            int end = asciiCode - firstDigit;

            char startLetter = (char) start;
            char endLetter = (char) end;

            string encryptedLetter = $"{startLetter}{middleNumbers}{endLetter}";

            return encryptedLetter;
        }
    }
}
