using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Phone
{
    class Program
    {
        static string[] phoneNumbers;
        static string[] phoneNames;
        static void Main(string[] args)
        {
            phoneNumbers = Console.ReadLine().Split(' ');
            phoneNames = Console.ReadLine().Split(' ');

            string[] command = Console.ReadLine().Split(' ');
            while (command[0] != "done")
            {
                string secondPart = command[1];

                if (command[0] == "call")
                {
                    if (IsNumber(secondPart))
                    {
                        Console.WriteLine("calling {0}...", WhatToPrint(secondPart));
                        CallMethod(phoneNumbers, phoneNames, command);
                    }
                    else
                    {
                        Console.WriteLine($"calling {WhatToPrint(secondPart)}...");
                        CallMethod(phoneNumbers, phoneNames, command);
                    }
                }
                else if (command[0] == "message")
                {
                    if (IsNumber(secondPart))
                    {
                        Console.WriteLine("sending sms to {0}...", WhatToPrint(secondPart));
                        MessageMethod(phoneNumbers, phoneNames, command);
                    }
                    else
                    {
                        Console.WriteLine("sending sms to {0}...", WhatToPrint(secondPart));
                        MessageMethod(phoneNumbers, phoneNames, command);
                    }
                }

                command = Console.ReadLine().Split(' ');
            }
        }

        static bool IsDigit(char character)
        {
            return (character >= '0' && character <= '9');
        }

        static bool IsNumber(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (IsDigit(input[i]))
                {
                    return true;
                }

            }
            return false;
        }

        static string WhatToPrint(string input)
        {
            for (int i = 0; i < phoneNumbers.Length; i++)
            {
                if (input == phoneNumbers[i])
                {
                    return phoneNames[i];
                }
                else if (input == phoneNames[i])
                {
                    return phoneNumbers[i];
                }
            }
            return string.Empty;
        }

        static void CallMethod(string[] phoneNumbers, string[] phoneNames, string[] command)
        {
            int sum = 0;
            int position = 0;

            for (int i = 0; i < phoneNames.Length; i++)
            {
                if (command[1] == phoneNames[i])
                {
                    position = i;
                }
                else if (command[1] == phoneNumbers[i])
                {
                    position = i;
                }
            }

            char[] digits = phoneNumbers[position].ToCharArray();

            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i] == '1' || digits[i] == '2' || digits[i] == '3' || digits[i] == '4'
                    || digits[i] == '5' || digits[i] == '6' ||
                    digits[i] == '7' || digits[i] == '8' || digits[i] == '9')
                {
                    int temporaryNumber = (int)char.GetNumericValue(digits[i]);
                    sum += temporaryNumber;
                }
            }

            int minutes = sum / 60;
            int seconds = sum % 60;
            string duration = $"{minutes:d2}:{seconds:d2}";

            if (sum % 2 == 0)
            {
                Console.WriteLine($"call ended. duration: {duration}");
            }
            else
            {
                Console.WriteLine("no answer");
            }
        }

        static void MessageMethod(string[] phoneNumbers, string[] phoneNames, string[] command)
        {
            int sum = 0;
            int position = 0;

            for (int i = 0; i < phoneNames.Length; i++)
            {
                if (command[1] == phoneNames[i])
                {
                    position = i;
                }
                else if (command[1] == phoneNumbers[i])
                {
                    position = i;
                }
            }

            char[] digits = phoneNumbers[position].ToCharArray();

            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i] == '1' || digits[i] == '2' || digits[i] == '3' || digits[i] == '4'
                    || digits[i] == '5' || digits[i] == '6' ||
                    digits[i] == '7' || digits[i] == '8' || digits[i] == '9')
                {
                    int temporaryNumber = (int)char.GetNumericValue(digits[i]);
                    sum += temporaryNumber;
                }
            }

            if (sum % 2 == 0)
            {
                Console.WriteLine("meet me there");
            }
            else
            {
                Console.WriteLine("busy");
            }
        }
    }
}