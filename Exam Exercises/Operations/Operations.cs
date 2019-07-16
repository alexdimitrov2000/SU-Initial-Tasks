using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    class Operations
    {
        static void Main(string[] args)
        {
            var firstNumber = double.Parse(Console.ReadLine());
            var secondNumber = double.Parse(Console.ReadLine());
            char readOperator = char.Parse(Console.ReadLine());

            double result = 0.0;
            if (secondNumber == 0)
            {
                Console.WriteLine($"Cannot divide {firstNumber} by zero");
            }
            else if (readOperator == '+')
            {
                result = firstNumber + secondNumber;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{firstNumber} {readOperator} {secondNumber} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{firstNumber} {readOperator} {secondNumber} = {result} - odd");
                }
            }
            else if (readOperator == '-')
            {
                result = firstNumber - secondNumber;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{firstNumber} {readOperator} {secondNumber} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{firstNumber} {readOperator} {secondNumber} = {result} - odd");
                }
            }
            else if (readOperator == '*')
            {
                result = firstNumber * secondNumber;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{firstNumber} {readOperator} {secondNumber} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{firstNumber} {readOperator} {secondNumber} = {result} - odd");
                }
            }
            else if (readOperator == '/')
            {
                result = firstNumber / secondNumber;
                Console.WriteLine($"{firstNumber} / {secondNumber} = {result:F2}");
            }
            else if (readOperator == '%')
            {
                result = firstNumber % secondNumber;
                Console.WriteLine($"{firstNumber} % {secondNumber} = {result}");
            }
            
        }
    }
}
