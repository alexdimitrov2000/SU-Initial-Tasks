using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distinct_List
{
    class DistinctList
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> finalList = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                if (!(finalList.Contains(list[i])))
                {
                    finalList.Add(list[i]);
                }    
            }

            Console.WriteLine(string.Join(" ", finalList));
        }
    }
}
