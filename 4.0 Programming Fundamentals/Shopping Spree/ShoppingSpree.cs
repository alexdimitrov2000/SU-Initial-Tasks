using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Spree
{
    class ShoppingSpree
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> productPrices = new Dictionary<string, double>();
            double budget = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] inputTokens = input.Split(' ');
                string product = inputTokens[0];
                double price = double.Parse(inputTokens[1]);

                if (!productPrices.ContainsKey(product))
                {
                    productPrices.Add(product, price);
                }
                else
                {
                    if (price < productPrices[product])
                    {
                        productPrices[product] = price;
                    }
                }

                input = Console.ReadLine();
            }

            double sumOfProductPrices = 0.0;

            foreach (var productPricePair in productPrices)
            {
                double currentPrice = productPricePair.Value;

                sumOfProductPrices += currentPrice;
            }

            if (sumOfProductPrices > budget)
            {
                Console.WriteLine("Need more money... Just buy banichka");
            }
            else
            {
                Dictionary<string, double> productsToPrint =
                    productPrices
                    .OrderBy(w => w.Key.Length)
                        .OrderByDescending(w => w.Value)
                        .ToDictionary(k => k.Key, v => v.Value);

                foreach (var products in productsToPrint)
                {
                    Console.WriteLine($"{products.Key} costs {products.Value:f2}");
                }
            }
        }
    }
}
