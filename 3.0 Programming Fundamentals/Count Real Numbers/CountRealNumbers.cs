using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Real_Numbers
{
    class CountRealNumbers
    {
        static void Main(string[] args)
        {
            SortedDictionary<double, int> numbersDictionary = new SortedDictionary<double, int>();
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (!numbersDictionary.ContainsKey(numbers[i]))
                {
                    numbersDictionary.Add(numbers[i], 0);
                }
                numbersDictionary[numbers[i]]++;
            }

            List<double> numbersList = new List<double>();
            
            foreach (KeyValuePair<double, int> item in numbersDictionary)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}
