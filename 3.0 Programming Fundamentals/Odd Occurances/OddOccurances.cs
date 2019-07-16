using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Occurances
{
    class OddOccurances
    {
        static void Main(string[] args)
        {
            var elements = new Dictionary<string, int>();
            string[] elementsArray = Console.ReadLine().ToLower().Split();
            int count = 0;
            List<string> finalList = new List<string>();

            for (int i = 0; i < elementsArray.Length; i++)
            {
                if (!elements.ContainsKey(elementsArray[i]))
                {
                    elements.Add(elementsArray[i], 0);
                }

                elements[elementsArray[i]]++;
            }

            foreach (KeyValuePair<string, int> items in elements)
            {
                if (items.Value % 2 != 0)
                {
                    finalList.Add(items.Key); 
                }
            }

            Console.WriteLine(string.Join(", ", finalList));
        }
    }
}
