using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Shopping
{
    class ExamShopping
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> products = new Dictionary<string, int>();

            string[] inputTokens = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string command = string.Empty;
            string product = string.Empty;
            int quantity = 0;
            List<string> outOfStock = new List<string>();
            List<string> doesntExist = new List<string>();

            while (inputTokens[0] != "shopping")
            {
                command = inputTokens[0];
                product = inputTokens[1];
                quantity = int.Parse(inputTokens[2]);
                if (!products.ContainsKey(product))
                {
                    products[product] = quantity;
                }
                else
                {
                    products[product] += quantity;
                }

                inputTokens = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }
            inputTokens = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            while (inputTokens[0] != "exam")
            {
                command = inputTokens[0];
                product = inputTokens[1];
                quantity = int.Parse(inputTokens[2]);


                if (products.ContainsKey(product))
                {
                    int stock = products[product];

                    if (stock == 0)
                    {
                        outOfStock.Add($"{product} out of stock");
                        Console.WriteLine($"{product} out of stock");
                    }
                    else if (quantity > stock)
                    {
                        products[product] = 0;
                    }
                    else
                    {
                        products[product] -= quantity;
                    }
                }
                else
                {
                    doesntExist.Add($"{product} doesn't exist");
                    Console.WriteLine($"{product} doesn't exist");
                }


                inputTokens = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }
            
            foreach (KeyValuePair<string, int> item in products)
            {
                if (item.Value > 0)
                {
                    Console.WriteLine("{0} -> {1}",
                        item.Key,
                        item.Value);
                }
            }
        }
    }
}
