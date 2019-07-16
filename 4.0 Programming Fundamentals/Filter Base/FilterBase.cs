using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filter_Base
{
    class FilterBase
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> agesDictionary = new Dictionary<string, int>();
            Dictionary<string, double> salaryDictionary = new Dictionary<string, double>();
            Dictionary<string, string> positionDictionary = new Dictionary<string, string>();

            string[] inputTokens = Console.ReadLine()
                .Split(new char[] {' ', '-', '>'}, StringSplitOptions.RemoveEmptyEntries);

            while (inputTokens[0] != "filter")
            {
                string name = inputTokens[0];
                string secondElement = inputTokens[1];
                int age = 0;
                double salary = 0.0;
                string position = string.Empty;

                if (int.TryParse(secondElement,out age))
                {
                    agesDictionary[name] = age;
                }
                else if (double.TryParse(secondElement, out salary))
                {
                    salaryDictionary[name] = salary;
                }
                else
                {
                    position = secondElement;
                    positionDictionary[name] = position;
                }

                inputTokens = Console.ReadLine()
                    .Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            }

            string category = Console.ReadLine().ToLower();

            if (category == "age")
            {
              // Name: Peter
              // Position: CEO
              // ====================

                foreach (KeyValuePair<string, int> item in agesDictionary)
                {
                    Console.WriteLine($"Name: {item.Key}");
                    Console.WriteLine($"Age: {item.Value}");
                    Console.WriteLine(new string('=', 20));
                }
            }
            else if (category == "salary")
            {
                foreach (KeyValuePair<string, double> item in salaryDictionary)
                {
                    Console.WriteLine($"Name: {item.Key}");
                    Console.WriteLine($"Salary: {item.Value:f2}");
                    Console.WriteLine(new string('=', 20));
                }
            }
            else if (category == "position")
            {
                foreach (KeyValuePair<string, string> item in positionDictionary)
                {
                    Console.WriteLine($"Name: {item.Key}");
                    Console.WriteLine($"Position: {item.Value}");
                    Console.WriteLine(new string('=', 20));
                }
            }
        }
    }
}
