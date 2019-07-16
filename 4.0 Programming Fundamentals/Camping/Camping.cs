using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camping
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, List<String>> mainDict = new Dictionary<string, List<string>>();
            Dictionary<string, int> nightsDict = new Dictionary<string, int>();

            while (input != "end")
            {
                string[] tokens = input.Split(' ');
                string personName = tokens[0];
                string camperModel = tokens[1];
                int timeToStay = int.Parse(tokens[2]);

                if (!mainDict.ContainsKey(personName))
                {
                    mainDict.Add(personName, new List<string>());
                }
                mainDict[personName].Add(camperModel);

                if (!nightsDict.ContainsKey(personName))
                {
                    nightsDict.Add(personName, 0);
                }
                nightsDict[personName] += timeToStay;

                input = Console.ReadLine();
            }

            var orderedDict = new Dictionary<string, List<string>>();

            orderedDict = mainDict
                .OrderByDescending(v => v.Value.Count)
                .ThenBy(k => k.Key.Length)
                .ToDictionary(k => k.Key, v => v.Value);

            foreach (var personCamper in orderedDict)
            {
                string currentPerson = personCamper.Key;
                Console.WriteLine($"{currentPerson}: {orderedDict[currentPerson].Count}");
                foreach (var camper in personCamper.Value)
                {
                    Console.WriteLine($"***{camper}");
                }
                Console.WriteLine($"Total stay: {nightsDict[currentPerson]} nights");
            }
        }
    }
}
