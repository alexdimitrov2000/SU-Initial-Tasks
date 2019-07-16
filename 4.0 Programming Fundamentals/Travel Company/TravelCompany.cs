using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_Company
{
    class TravelCompany
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> wholeDictionary =
                                                        new Dictionary<string, Dictionary<string, int>>();

            Dictionary<string, int> townAndCapacities = new Dictionary<string, int>();
            string input = Console.ReadLine();
            string[] currentTransportCapacity = new string[]{};
            string currentTransport = string.Empty;
            int currentCapacity = 0;
            int fullCapacity = 0;
            string town = string.Empty;
            while (input != "ready")
            {
                string[] companyOffers = input.Split(':');
                town = companyOffers[0];
                string[] transportCapacity = companyOffers[1].Split(',');

                if (!wholeDictionary.ContainsKey(town))
                {
                    wholeDictionary.Add(town, new Dictionary<string, int>());
                }
                for (int i = 0; i < transportCapacity.Length; i++)
                {
                    currentTransportCapacity = transportCapacity[i].Split('-');
                    currentTransport = currentTransportCapacity[0];
                    currentCapacity = int.Parse(currentTransportCapacity[1]);
                    if (!wholeDictionary[town].ContainsKey(currentTransport))
                    {
                        wholeDictionary[town].Add(currentTransport, 0);
                    }
                    wholeDictionary[town][currentTransport] = currentCapacity;
                }


                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            while (input != "travel time!")
            {
                string[] townCapacityTokens = input.Split(' ');
                town = townCapacityTokens[0];
                int neededCapacity = int.Parse(townCapacityTokens[1]);
                fullCapacity = 0;

                foreach (var townCapPair in wholeDictionary)
                {
                    if (townCapPair.Key == town)
                    {
                        var currentValue = townCapPair.Value;
                        foreach (var capacities in currentValue.Values)
                        {
                            fullCapacity += capacities;
                        }
                    }
                }
                if (fullCapacity >= neededCapacity)
                {
                    Console.WriteLine($"{town} -> all {neededCapacity} accommodated");
                }
                else
                {
                    Console.WriteLine($"{town} -> all except {neededCapacity - fullCapacity} accommodated");
                }

                input = Console.ReadLine();
            }
        }
    }
}
