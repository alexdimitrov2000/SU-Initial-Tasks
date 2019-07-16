using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_To_Words
{
    class NumbersToWords
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int digitOfHundreds = number / 100;
            int digitOfTens = number / 10 % 10;
            int digitOfUnits = number % 10;

            string hundredsWithWords = string.Empty;
            string tensWithWords = string.Empty;
            string unitsWithWords = string.Empty;

            string numberWithWords = string.Empty;

            switch (digitOfHundreds)
            {
                case 1:
                    hundredsWithWords = "one-hundred and";
                    break;
                case 2:
                    hundredsWithWords = "two-hundred and";
                    break;
                case 3:
                    hundredsWithWords = "three-hundred and";
                    break;
                case 4:
                    hundredsWithWords = "four-hundred and";
                    break;
                case 5:
                    hundredsWithWords = "five-hundred and";
                    break;
                case 6:
                    hundredsWithWords = "six-hundred and";
                    break;
                case 7:
                    hundredsWithWords = "seven-hundred and";
                    break;
                case 8:
                    hundredsWithWords = "eight-hundred and";
                    break;
                case 9:
                    hundredsWithWords = "nine-hundred and";
                    break;
            }

            switch (digitOfTens)
            {
                case '0':
                    tensWithWords = string.Empty;
                    break;
                case '2':
                    tensWithWords = "twenty";
                    break;
                case '3':
                    tensWithWords = "thirty";
                    break;
                case '4':
                    tensWithWords = "forty";
                    break;
                case '5':
                    tensWithWords = "fifty";
                    break;
                case '6':
                    tensWithWords = "sixty";
                    break;
                case '7':
                    tensWithWords = "seventy";
                    break;
                case '8':
                    tensWithWords = "eighty";
                    break;
                case '9':
                    tensWithWords = "ninety";
                    break;
            }

            if (digitOfTens == 1)
            {
                if (digitOfUnits == 0)
                {
                    numberWithWords = $"{hundredsWithWords} ten";
                }
                else if (digitOfUnits == 1)
                {
                    numberWithWords = $"{hundredsWithWords} eleven";
                }
                else if (digitOfUnits == 2)
                {
                    numberWithWords = $"{hundredsWithWords} twelve";
                }
                else if (digitOfUnits == 3)
                {
                    numberWithWords = $"{hundredsWithWords} thirteen";
                }
                else if (digitOfUnits == 4)
                {
                    numberWithWords = $"{hundredsWithWords} fourteen";
                }
                else if (digitOfUnits == 5)
                {
                    numberWithWords = $"{hundredsWithWords} fifteen";
                }
                else if (digitOfUnits == 6)
                {
                    numberWithWords = $"{hundredsWithWords} sixteen";
                }
                else if (digitOfUnits == 7)
                {
                    numberWithWords = $"{hundredsWithWords} seventeen";
                }
                else if (digitOfUnits == 8)
                {
                    numberWithWords = $"{hundredsWithWords} eighteen";
                }
                else if (digitOfUnits == 9)
                {
                    numberWithWords = $"{hundredsWithWords} nineteen";
                }
            }


            Console.WriteLine(numberWithWords);
        }
    }
}
