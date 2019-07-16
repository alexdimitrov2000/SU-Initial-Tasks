using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiningCoins_Broken
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string decrypted = "";
            float totalValue = 0.0f;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                int firstDigit = number / 100;
                int middleDigit = (number % 100) / 10;
                int lastDigit = number % 10;

                int twoDigitNumber = Convert.ToInt32(string.Format("{0}{1}", firstDigit, lastDigit));

                int ASCIIcode = 0;

                if (i % 2 == 0)
                {
                    twoDigitNumber += middleDigit;
                    ASCIIcode = ((firstDigit * 10) + lastDigit) - middleDigit;
                }
                else
                {
                    twoDigitNumber -= middleDigit;
                    ASCIIcode = ((firstDigit * 10) + lastDigit) + middleDigit;
                }

                if ((ASCIIcode >= 65 && ASCIIcode <= 90)
                    || (ASCIIcode >= 97 && ASCIIcode <= 122))
                {
                    decrypted += (char)ASCIIcode;
                }
                totalValue += (firstDigit + middleDigit + lastDigit) / (float)n;
            }


            Console.WriteLine("Message: {0}", decrypted);
            Console.WriteLine("Value: {0:F7}", totalValue);
        }
    }
}
