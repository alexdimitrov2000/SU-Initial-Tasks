using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Default_Values
{
    class DefaultValues
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, string> dict = new Dictionary<string, string>();

            while (input != "end")
            {
                string[] inputTokens = input.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string key = inputTokens[0];
                string value = inputTokens[1];
                dict[key] = value;

                input = Console.ReadLine();
            }

            Dictionary<string, string> nullValues = dict
                .Where(w => w.Value == "null")
                .ToDictionary(k => k.Key, v => v.Value);

            input = Console.ReadLine();

            Dictionary<string, string> newNullValues = new Dictionary<string, string>();

            foreach (var nullValue in nullValues)
            {
                string currentKey = nullValue.Key;
                newNullValues[currentKey] = input;
            }

            Dictionary<string, string> finalDict = dict
                .Where(w => w.Value != "null")
                .Reverse()
                .OrderByDescending(w => w.Value.Length)
                .ToDictionary(w => w.Key, v => v.Value);

            foreach (var kvp in newNullValues)
            {
                string currentKey = kvp.Key;

                finalDict[currentKey] = kvp.Value;
            }

            foreach (var items in finalDict)
            {
                Console.WriteLine($"{items.Key} <-> {items.Value}");
            }
        }
    }
}
