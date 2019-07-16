using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Array_In_Place
{
    class ReverseArrayInPlace
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < list.Count; i++)
            {
                int currentElement = list[i];
                int rightPart = list.Count - i - 1;
                int leftPart = i;

                if (rightPart > leftPart)
                {
                    list[leftPart] = list[rightPart];
                    list[rightPart] = currentElement;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
