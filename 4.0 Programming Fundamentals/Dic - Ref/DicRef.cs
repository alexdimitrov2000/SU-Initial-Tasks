using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dic___Ref
{
    class DicRef
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            string[] inputTokens = Console.ReadLine().Split(new char[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries);
            char character = default(char);

            while (inputTokens[0] != "end")
            {
                string inputKey = inputTokens[0];
                string inputValue = inputTokens[1];
                
                int number;
                if (int.TryParse(inputValue, out number))
                {
                    dictionary[inputKey] = number;
                }
                else
                {
                    if (dictionary.ContainsKey(inputValue))
                    {
                        dictionary[inputKey] = dictionary[inputValue];
                    }
                }

                inputTokens = Console.ReadLine().Split(new char[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (KeyValuePair<string, int> item in dictionary)
            {
                Console.WriteLine("{0} === {1}",
                                   item.Key,
                                   item.Value);
            }
        }
    }
}
