using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

class TrickyStrings
{
    static void Main(string[] args)
    {
        string delimiter = Console.ReadLine();
        var numberOfStrings = int.Parse(Console.ReadLine());
        var result = string.Empty;
        var currentString = string.Empty;
        for (int i = 0; i < numberOfStrings; i++)
        {
            currentString = Console.ReadLine();
            if (currentString == " ")
            {
                currentString = string.Empty;
            }
            if (i + 1 == numberOfStrings)
            {
                result += currentString;
            }
            else
            {
                result += currentString + delimiter;
            }
        }
        Console.WriteLine(result);
    }
}
