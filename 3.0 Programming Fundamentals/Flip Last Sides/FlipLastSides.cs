using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flip_Last_Sides
{
    class FlipLastSides
    {
        static void Main(string[] args)
        {
            List<int> listElements = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 1; i < listElements.Count - 1; i++)
            {
                int left = i;
                int right = listElements.Count - i - 1;

                if((right == left) || (left > right))
                {
                    break;
                }
                else
                {
                    SwapElements(listElements, left, right);
                }
                
            }

            Console.WriteLine(string.Join(" ", listElements));
        }

        static void SwapElements(List<int> list, int firstIndex, int secondIndex)
        {
            int temporary = firstIndex;
            int previousElement = list[temporary];
            list[firstIndex] = list[secondIndex];
            list[secondIndex] = previousElement;
        }
    }
}
