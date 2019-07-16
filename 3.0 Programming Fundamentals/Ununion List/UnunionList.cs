using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ununion_List
{
    class UnunionList
    {
        static void Main(string[] args)
        {
            List<int> primalList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int repeatance = int.Parse(Console.ReadLine());

            for (int i = 0; i < repeatance; i++)
            {
                List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

                for (int j = 0; j < list.Count; j++)
                {
                    if (primalList.Contains(list[j]))
                    {
                        primalList.Remove(list[j]);
                    }
                    else
                    {
                        primalList.Add(list[j]);
                    }
                }
            }

            primalList.Sort();

            Console.WriteLine(string.Join(" ", primalList));
        }
    }
}
