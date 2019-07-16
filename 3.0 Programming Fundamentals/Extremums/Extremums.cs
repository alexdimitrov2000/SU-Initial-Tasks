using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Extremums
{
    class Extremums
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string action = Console.ReadLine();
            string digits = string.Empty;
            int currentNumber = 0;
            int sum = 0;
            List<int> outputNumbers = new List<int>();

            if (action == "Min")
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    digits = numbers[i].ToString();
                    currentNumber = 0;
                    sum += MinSum(digits);
                    currentNumber = MinSum(digits);
                    outputNumbers.Add(currentNumber);
                }
            }
            else if (action == "Max")
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    digits = numbers[i].ToString();
                    currentNumber = 0;
                    sum += MaxSum(digits);
                    currentNumber = MaxSum(digits);
                    outputNumbers.Add(currentNumber);
                }
            }
            Console.WriteLine(string.Join(", ", outputNumbers));
            Console.WriteLine(sum);
        }
        
        static string RotateNumberDigits(string digits)
        {
            List<char> charDigitsList = digits.ToCharArray().ToList();

            string number = string.Empty;
            for (int i = 0; i < charDigitsList.Count - 1; i++)
            {
                char first = charDigitsList[0];
                charDigitsList.RemoveAt(0);
                charDigitsList.Add(first);
            }
            for (int i = 0; i < charDigitsList.Count; i++)
            {
                number += charDigitsList[i];
            }
            return number;
        }

        static int MinSum(string digits)
        {
            string number = string.Empty;
            int currentNumber = 0;
            int finalMinNumber = int.MaxValue;
            int minSum = 0;
            for (int i = 0; i < digits.Length; i++)
            {
                number = RotateNumberDigits(digits);
                currentNumber = int.Parse(number);
                if (currentNumber < finalMinNumber)
                {
                    finalMinNumber = currentNumber;
                }
                digits = number;
            }
            minSum += finalMinNumber;

            return minSum;
        }

        static int MaxSum(string digits)
        {
            string number = string.Empty;
            int currentNumber = 0;
            int finalMinNumber = int.MinValue;
            int maxSum = 0;
            for (int i = 0; i < digits.Length; i++)
            {
                number = RotateNumberDigits(digits);
                currentNumber = int.Parse(number);
                if (currentNumber > finalMinNumber)
                {
                    finalMinNumber = currentNumber;
                }
                digits = number;
            }
            maxSum += finalMinNumber;

            return maxSum;
        }
    }
}
