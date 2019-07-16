using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wardrobe
{
    class Wardrobe
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> clothesDictionary = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> clothCountDictionary = new Dictionary<string, int>();
            int count = int.Parse(Console.ReadLine());
            string color = String.Empty;
            List<string> clothes = new List<string>();
            for (int counter = 0; counter < count; counter++)
            {
                string[] inputTokens = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                color = inputTokens[0];
                clothes = inputTokens[1].Split(',').ToList();

                if (!clothesDictionary.ContainsKey(color))
                {
                    clothesDictionary.Add(color, new Dictionary<string, int>());
                }
                for (int i = 0; i < clothes.Count; i++)
                {
                    string currentCloth = clothes[i];
                    if (!clothesDictionary[color].ContainsKey(currentCloth))
                    {
                        clothesDictionary[color].Add(currentCloth, 0);
                    }
                    clothesDictionary[color][currentCloth]++;
                }
            }

            string[] colorClothesToFind = Console.ReadLine().Split(' ');
            string colorToFind = colorClothesToFind[0];
            string clothToFind = colorClothesToFind[1];
            Dictionary<string, int> finalClothes = new Dictionary<string, int>();
            int countForTheClothes = 0;

            foreach (KeyValuePair<string, Dictionary<string, int>> clothesPair in clothesDictionary)
            {
                string currentColor = clothesPair.Key;
                Console.WriteLine($"{currentColor} clothes:");
                foreach (KeyValuePair<string, int> currentCloth in clothesPair.Value)
                {
                    string clothToPrint = currentCloth.Key;
                    int quantity = currentCloth.Value;
                    if (currentColor == colorToFind && clothToPrint == clothToFind)
                    {
                        Console.WriteLine($"* {clothToPrint} - {quantity} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {clothToPrint} - {quantity}");
                    }
                }
            }
        }
    }
}
