using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mixed_Phones
{
    class MixedPhones
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, long> phoneBook = new SortedDictionary<string, long>();

            string[] inputTokens = Console.ReadLine().Split(' ');
            char character = default(char);
            string personName = string.Empty;
            long personNumber = 0L;

            while (inputTokens[0] != "Over")
            {
                personName = inputTokens[0];
                character = personName[0];
                if (!(character >= '0' && character <= '9'))
                {
                    personName = inputTokens[0];
                    personNumber = long.Parse(inputTokens[2]);
                }
                else
                {
                    personName = inputTokens[2];
                    personNumber = long.Parse(inputTokens[0]);
                }

                if (!phoneBook.ContainsKey(personName))
                {
                    phoneBook.Add(personName, personNumber);
                }
                
                inputTokens = Console.ReadLine().Split(' ');
            }

            foreach (KeyValuePair<string, long> item in phoneBook)
            {
                Console.WriteLine("{0} -> {1}",
                                   item.Key,
                                   item.Value);
            }
        }
    }
}
