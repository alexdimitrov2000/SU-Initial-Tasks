using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQuistics
{
    class LINQuistics
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, List<string>> collectionMethods = new Dictionary<string, List<string>>();

            while (input != "exit")
            {
                if (input.Contains('.'))
                {
                    string[] tokens = input.Split(new [] { '.', '(', ')' }, 
                        StringSplitOptions.RemoveEmptyEntries);

                    string collection = tokens[0];
                    List<string> inputMethods = new List<string>();
                    inputMethods.AddRange(tokens.Skip(1));

                    if (!collectionMethods.ContainsKey(collection))
                    {
                        collectionMethods.Add(collection , new List<string>());
                    }
                    collectionMethods[collection].AddRange(inputMethods);
                }
                else if (input.Length == 1)
                {
                    int number;
                    bool isNum = int.TryParse(input, out number);
                    if (isNum)
                    {
                        KeyValuePair<string, List<string>> collectionWithMostElements = collectionMethods
                            .OrderByDescending(v => v.Value.Count)
                            .First();

                        List<string> methodsToPrint = collectionWithMostElements.Value
                            .Distinct()
                            .OrderBy(m => m.Length)
                            .Take(number)
                            .ToList();
                        foreach (var method in methodsToPrint)
                        {
                            Console.WriteLine($"* {method}");
                        }
                    }
                    else
                    {
                        if (collectionMethods.ContainsKey(input))
                        {
                            List<string> currentMethods = collectionMethods[input]
                                .Distinct()
                                .OrderByDescending(m => m.Length)
                                .ThenByDescending(m => m.ToCharArray().Distinct().Count())
                                .ToList();

                            foreach (var method in currentMethods)
                            {
                                Console.WriteLine($"* {method}");
                            }
                        }
                    }
                }
                else
                {
                    if (collectionMethods.ContainsKey(input))
                    {
                        List<string> currentMethods = collectionMethods[input]
                            .Distinct()
                            .OrderByDescending(m => m.Length)
                            .ThenByDescending(m => m.ToCharArray().Distinct().Count())
                            .ToList();

                        foreach (var method in currentMethods)
                        {
                            Console.WriteLine($"* {method}");
                        }
                    }
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            string[] finalTokens = input.Split(' ');
            string finalMethod = finalTokens[0];
            string finalSelection = finalTokens[1];

            var finalCollection = collectionMethods
                .Where(v => v.Value.Contains(finalMethod))
                .OrderByDescending(v => v.Value.Count)
                .ThenByDescending(m => m.Value.OrderBy(w => w.Length).First().Length)
                .ToDictionary(k => k.Key, v => v.Value);

            if (finalSelection == "collection")
            {
                foreach (var collection in finalCollection)
                {
                    Console.WriteLine(collection.Key);
                }
            }
            else if (finalSelection == "all")
            {
                foreach (var collection in finalCollection)
                {
                    string currentCollection = collection.Key;
                    List<string> currentMethods = collection.Value
                        .Distinct()
                        .OrderByDescending(m => m.Length)
                        .ToList();

                    Console.WriteLine(currentCollection);
                    foreach (var method in currentMethods)
                    {
                        Console.WriteLine($"* {method}");
                    }
                }
            }
        }
    }
}
