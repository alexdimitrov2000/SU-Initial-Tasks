using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stuck_Zipper
{
    class StuckZipper
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int smallestElement = Int32.MaxValue;

            List<int> zippedList = new List<int>();

            smallestElement = Math.Abs(FindSmallestElement(firstList, secondList, smallestElement));
            int smallestDigited = FindNumberLength(smallestElement);

            RemoveUnnecessaryElements(firstList, secondList, smallestDigited);

            int startingNumber = 0;

            int endOfLoop = Math.Max(firstList.Count, secondList.Count);
            for (int i = 0; i < endOfLoop; i++)
            {
                if (i < secondList.Count)
                {
                    zippedList.Add(secondList[i]);
                }
                if (i < firstList.Count)
                {
                    zippedList.Add(firstList[i]);
                }
            }

            Console.WriteLine(string.Join(" ", zippedList));
        }

        static int FindSmallestElement(List<int> firstList, List<int> secondList, int smallestElement)
        {
            for (int i = 0; i < firstList.Count; i++)
            {
                int element = Math.Abs(firstList[i]);
                if (element < smallestElement)
                {
                    smallestElement = element;
                }
            }

            for (int i = 0; i < secondList.Count; i++)
            {
                int element = Math.Abs(secondList[i]);
                if (element < smallestElement)
                {
                    smallestElement = element;
                }
            }

            return smallestElement;
        }

        static void RemoveUnnecessaryElements(List<int> firstList, List<int> secondList, int smallestDigited)
        {
            for (int i = 0; i < firstList.Count; i++)
            {
                if (FindNumberLength(firstList[i]) > smallestDigited)
                {
                    firstList.RemoveAt(i);
                    i--;
                }
            }

            for (int i = 0; i < secondList.Count; i++)
            {
                if (FindNumberLength(secondList[i]) > smallestDigited)
                {
                    secondList.RemoveAt(i);
                    i--;
                }
            }
        }

        static int FindNumberLength(int smallestElement)
        {
            int digitNumber = 0;

            smallestElement = Math.Abs(smallestElement);

            while (smallestElement > 0)
            {
                smallestElement /= 10;
                digitNumber++;
            }

            return digitNumber;
        }
    }
}
