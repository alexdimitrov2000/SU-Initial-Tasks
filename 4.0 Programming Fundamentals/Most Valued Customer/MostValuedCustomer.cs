using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Most_Valued_Customer
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, decimal> productsDict = new Dictionary<string, decimal>();

            while (input != "Shop is open")
            {
                string[] tokens = input.Split(' ');
                string product = tokens[0];
                decimal productPrice = decimal.Parse(tokens[1]);

                productsDict.Add(product, productPrice);

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            var sortedProducts = new Dictionary<string, decimal>();

            Dictionary<string, List<string>> customersDict = new Dictionary<string, List<string>>();

            while (input != "Print")
            {
                string[] tokens = input.Split(new [] { ": " }, StringSplitOptions.RemoveEmptyEntries);
                sortedProducts = productsDict
                    .OrderByDescending(v => v.Value)
                    .ToDictionary(k => k.Key, v => v.Value);
                if (input == "Discount")
                {
                    var products = sortedProducts.Take(3).ToDictionary(k => k.Key, v => v.Value);
                    foreach (var product in products)
                    {
                        string currentProduct = product.Key;
                        decimal currentPrice = product.Value;

                        productsDict[currentProduct] = currentPrice - currentPrice * 0.10m;
                    }
                }
                else
                {
                    bool mustAdd = true;
                    string customer = tokens[0];
                    List<string> products = tokens[1].Split(new[] { ", " }
                        , StringSplitOptions.RemoveEmptyEntries).ToList();

                    if (!customersDict.ContainsKey(customer))
                    {
                        customersDict.Add(customer, new List<string>());
                    }
                    foreach (var product in products)
                    {
                        mustAdd = true;
                        if (!productsDict.ContainsKey(product))
                        {
                            mustAdd = false;
                            break;
                        }
                    }
                    if (mustAdd)
                    {
                        customersDict[customer].AddRange(products);
                    }
                    
                }
                input = Console.ReadLine();
            }

            Dictionary<string, decimal> customerSpends = new Dictionary<string, decimal>();
           

            foreach (var customer in customersDict)
            {
                string currentCustomer = customer.Key;
                List<string> currentProducts = customer.Value;

                if (!customerSpends.ContainsKey(currentCustomer))
                {
                    customerSpends.Add(currentCustomer, 0.0m);
                }

                foreach (var currentProduct in currentProducts)
                {
                    customerSpends[currentCustomer] += sortedProducts[currentProduct];
                }
            }

            var finalCustomerSpends = customerSpends
                .OrderByDescending(v => v.Value)
                .ToDictionary(k => k.Key, v => v.Value);
            string mostValuedCustomer = finalCustomerSpends.First().Key;

            List<string> finalProductsList =
                customersDict[mostValuedCustomer].Distinct().ToList();

            productsDict = new Dictionary<string, decimal>();
            foreach (var product in finalProductsList)
            {
                productsDict.Add(product, sortedProducts[product]);
            }

            var productsToPrint = productsDict
                .OrderByDescending(v => v.Value)
                .ToDictionary(k => k.Key, v => v.Value);

            Console.WriteLine($"Biggest spender: {mostValuedCustomer}");
            Console.WriteLine("^Products bought:");
            foreach (var product in productsToPrint)
            {
                Console.WriteLine($"^^^{product.Key}: {product.Value:f2}");
            }
            Console.WriteLine($"Total: {customerSpends[mostValuedCustomer]:f2}");
        }
    }
}
