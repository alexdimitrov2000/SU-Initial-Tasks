using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CottageScraper
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var allLogs = new Dictionary<string, List<int>>();
            int numberOfTrees = 0;

            while (input != "chop chop")
            {
                string[] tokens = input.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string log = tokens[0];
                int logLength = int.Parse(tokens[1]);

                if (!allLogs.ContainsKey(log))
                {
                    allLogs.Add(log, new List<int>());
                }
                allLogs[log].Add(logLength);
                numberOfTrees++;
                input = Console.ReadLine();
            }

            int sumOfLogs = 0;
            foreach (var allLog in allLogs)
            {
                foreach (var allLogsValue in allLog.Value)
                {
                    sumOfLogs += allLogsValue;
                }
            }

            double pricePerMeter = Math.Round(((double)sumOfLogs / numberOfTrees), 2);

            string logForScraper = Console.ReadLine();
            int logLengthForScraper = int.Parse(Console.ReadLine());

            Dictionary<string, List<int>> usedLogs =
                allLogs.Where(k => k.Key == logForScraper)
                    .ToDictionary(k => k.Key, v => v.Value);
            Dictionary<string, List<int>> unusedLogs =
                allLogs.Where(k => k.Key != logForScraper)
                    .ToDictionary(k => k.Key, v => v.Value);

            var finalUsedLogs = new Dictionary<string, List<int>>();
            foreach (var usedLog in usedLogs)
            {
                string currentTree = usedLog.Key;
                List<int> currentLengths = usedLog.Value;
                foreach (var currentLength in currentLengths)
                {
                    if (currentLength >= logLengthForScraper)
                    {
                        if (!finalUsedLogs.ContainsKey(currentTree))
                        {
                            finalUsedLogs.Add(currentTree, new List<int>());
                        }
                        finalUsedLogs[currentTree].Add(currentLength);
                    }
                    else
                    {
                        if (!unusedLogs.ContainsKey(currentTree))
                        {
                            unusedLogs.Add(currentTree, new List<int>());
                        }
                        unusedLogs[currentTree].Add(currentLength);
                    }
                }
            }

            int sumOfUsedLogs = 0;
            foreach (var usedLog in finalUsedLogs)
            {
                foreach (var length in usedLog.Value)
                {
                    sumOfUsedLogs += length;
                }
            }
            double priceOfUsedLogs = Math.Round((sumOfUsedLogs * pricePerMeter), 2);

            int sumOfUnusedLogs = 0;
            foreach (var unusedLog in unusedLogs)
            {
                foreach (var length in unusedLog.Value)
                {
                    sumOfUnusedLogs += length;
                }
            }

            double priceOfUnusedLogs = Math.Round((sumOfUnusedLogs * pricePerMeter * 0.25), 2);
            double cottageScraperSubtotal = priceOfUsedLogs + priceOfUnusedLogs;

            Console.WriteLine($"Price per meter: ${pricePerMeter:f2}");
            Console.WriteLine($"Used logs price: ${priceOfUsedLogs:f2}");
            Console.WriteLine($"Unused logs price: ${priceOfUnusedLogs:f2}");
            Console.WriteLine($"CottageScraper subtotal: ${cottageScraperSubtotal:f2}");
        }
    }
}
