using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camel_s_Back
{
    class CamelBack
    {
        static void Main(string[] args)
        {
            List<int> NBuildingsList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int MCamelBackSize = int.Parse(Console.ReadLine());

            int rounds = 0;
            while (NBuildingsList.Count != MCamelBackSize)
            {
                for (int i = 0; i < NBuildingsList.Count; i++)
                {
                    NBuildingsList.RemoveAt(i);
                    NBuildingsList.RemoveAt(NBuildingsList.Count - i - 1);

                    rounds++;
                    i --;

                    if (NBuildingsList.Count == MCamelBackSize)
                    {
                        break;
                    }
                }
            }

            if (rounds == 0)
            {
                Console.WriteLine($"already stable: {string.Join(" ", NBuildingsList)}");
            }
            else
            {
                Console.WriteLine($"{rounds} rounds");
                Console.WriteLine($"remaining: {string.Join(" ", NBuildingsList)}");
            }
        }
    }
}
