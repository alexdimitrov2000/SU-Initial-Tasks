using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cities_By_Continent_And_Country
{
    class CitiesByContinentsAndCountry
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> continentsDictionary = new Dictionary<string, Dictionary<string, List<string>>>();
            Dictionary<string, List<string>> countriesDictionary = new Dictionary<string, List<string>>();
            List<string> cities = new List<string>();

            string[] input = new string[]{};
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split(' ');
                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (!continentsDictionary.ContainsKey(continent))
                {
                    continentsDictionary[continent] = new Dictionary<string, List<string>>();
                }
                if (!continentsDictionary[continent].ContainsKey(country))
                {
                    continentsDictionary[continent][country] = new List<string>();
                    continentsDictionary[continent][country].Add(city);
                }
                else
                {
                    continentsDictionary[continent][country].Add(city);
                }
            }

            foreach (KeyValuePair<string, Dictionary<string, List<string>>> pair in continentsDictionary)
            {
                Console.WriteLine($"{pair.Key}:");

                string finalContinents = pair.Key;
                Dictionary<string, List<string>> finalCountries = pair.Value;

                foreach (KeyValuePair<string, List<string>> countryPair in finalCountries)
                {
                    string finalCities = string.Join(", ", countryPair.Value);

                    Console.WriteLine($"  {countryPair.Key} -> {finalCities}");
                }
            }
        }
    }
}
