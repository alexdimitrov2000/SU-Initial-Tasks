using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Continents__Countries_and_Cities
{
    class GroupContinentsCountriesAndCities
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedDictionary<string, SortedDictionary<string, SortedSet<string>>> continentsDictionary = new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();
            SortedDictionary<string, SortedSet<string>> countriesDictionary = new SortedDictionary<string, SortedSet<string>>();
            List<string> citiesList = new List<string>();

            string[] input = new string[] { };

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split(' ');

                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (!continentsDictionary.ContainsKey(continent))
                {
                    continentsDictionary[continent] = new SortedDictionary<string, SortedSet<string>>();
                }
                if (!continentsDictionary[continent].ContainsKey(country))
                {
                    continentsDictionary[continent][country] = new SortedSet<string>();
                    continentsDictionary[continent][country].Add(city);
                }
                else
                {
                    if (!continentsDictionary[continent][country].Contains(city))
                    {
                        continentsDictionary[continent][country].Add(city);
                    }
                }
            }

            foreach (KeyValuePair<string, SortedDictionary<string, SortedSet<string>>> continentsPair in continentsDictionary)
            {
                string finalContinent = continentsPair.Key;
                Console.WriteLine($"{finalContinent}:");

                SortedDictionary<string, SortedSet<string>> finalCountries = continentsPair.Value;
                foreach (KeyValuePair<string, SortedSet<string>> countryPair in finalCountries)
                {
                    string finalCountry = countryPair.Key;
                    string finalCities = string.Join(", ", countryPair.Value);

                    Console.WriteLine($"  {finalCountry} -> {finalCities}");
                }
            }
        }
    }
}
