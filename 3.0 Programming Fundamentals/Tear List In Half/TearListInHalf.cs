using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tear_List_In_Half
{
    class TearListInHalf
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int elementsInLeftPart = list.Count / 2;
            int elementsInRightPart = list.Count - elementsInLeftPart;

            List<int> leftPart = new List<int>();
            List<int> rightPart = new List<int>();

            for (int i = 0; i < elementsInLeftPart; i++)
            {
                leftPart.Add(list[i]);
            }

            for (int i = elementsInLeftPart; i < list.Count; i++)
            {
                rightPart.Add(list[i]);
            }

            List<int> finalList = new List<int>();

            for (int i = 0; i < leftPart.Count; i++)
            {
                int number = rightPart[i];
                int firstDigit = number / 10 % 10;
                int secondDigit = number % 10;

                finalList.Add(firstDigit);
                finalList.Add(leftPart[i]);
                finalList.Add(secondDigit);
            }

            Console.WriteLine(string.Join(" ", finalList));
        }
    }
}
