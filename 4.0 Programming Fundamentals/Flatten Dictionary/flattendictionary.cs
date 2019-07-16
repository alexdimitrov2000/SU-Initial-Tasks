using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flatten_Dictionary
{
    class FlattenDictionary
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, string>> dictionary =
                new Dictionary<string, Dictionary<string, string>>();
            string word = string.Empty;

            Dictionary<string, List<string>> flattenedValues = new Dictionary<string, List<string>>();
            string key = String.Empty;
            string innerKey = string.Empty;
            string innerValue = string.Empty;
            string keyToFlatten = string.Empty;

            while (input != "end")
            {
                string[] inputTokens = input.Split(' ');

                if (inputTokens[0] == "flatten")
                {
                    keyToFlatten = inputTokens[1];
                    if (!flattenedValues.ContainsKey(keyToFlatten))
                    {
                        flattenedValues.Add(keyToFlatten, new List<string>());
                    }
                    foreach (var dictKeys in dictionary[keyToFlatten])
                    {
                        string firstWord = dictKeys.Key;
                        string secondWord = dictKeys.Value;
                        word = firstWord + secondWord;
                        flattenedValues[keyToFlatten].Add(word);
                    }
                    dictionary[keyToFlatten] = new Dictionary<string, string>();
                }
                else
                {
                    key = inputTokens[0];
                    innerKey = inputTokens[1];
                    innerValue = inputTokens[2];
                    if (!dictionary.ContainsKey(key))
                    {
                        dictionary.Add(key, new Dictionary<string, string>());
                    }
                    dictionary[key][innerKey] = innerValue;
                }

                input = Console.ReadLine();
            }

            Dictionary<string, Dictionary<string, string>> finalDict =
                new Dictionary<string, Dictionary<string, string>>();

            finalDict = dictionary
                .OrderByDescending(k => k.Key.Length)
                .ToDictionary(k => k.Key, v => v.Value);
            int lastProductNum = 0;
            
            foreach (var Kkvp in finalDict)
            {
                int numberOfProduct = 0;
                string currentKey = Kkvp.Key;
                var innerRecords = Kkvp.Value;
                var valuesToPrint = innerRecords
                    .OrderBy(k => k.Key.Length)
                    .ToDictionary(k => k.Key, v => v.Value);
                Console.WriteLine(Kkvp.Key);
                foreach (var products in valuesToPrint)
                {
                    numberOfProduct++;
                    Console.WriteLine($"{numberOfProduct}. {products.Key} - {products.Value}");
                }
                lastProductNum = numberOfProduct;
                if (flattenedValues.ContainsKey(currentKey))
                {
                    foreach (var flattenedValue in flattenedValues[currentKey])
                    {
                            lastProductNum++;
                            Console.WriteLine($"{lastProductNum}. {flattenedValue}");
                    }
                }
                
            }
            
        }
    }
}
