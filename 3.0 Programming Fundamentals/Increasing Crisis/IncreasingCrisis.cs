using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increasing_Crisis
{
    class IncreasingCrisis
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] sequenceOfNumbers = new int[] { };
            int[] lastSequence = new int[] { };
            List<int> listOfIntegers = new List<int> { };
            int currentNumber = 0;
            int lastNumber = 0;
            int firstSequenceNumber = 0;
            int lastNumberSmallerThanTheFirst = 0;
            for (int i = 0; i < n; i++)
            {
                sequenceOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int g = 0; g < sequenceOfNumbers.Length; g++)
                {
                    firstSequenceNumber = sequenceOfNumbers[0];
                    if (i == 0)
                    {
                        listOfIntegers.Add(sequenceOfNumbers[g]);
                    }
                    else
                    {
                        AddToTheNewList(listOfIntegers, lastNumberSmallerThanTheFirst, sequenceOfNumbers, lastNumber);
                        break;
                    }
                }
                lastSequence = sequenceOfNumbers;
            }
            Console.WriteLine(string.Join(" ", listOfIntegers));
        }

        static int FindTheBiggestSmallNum(int firstSequenceNumber,
            int lastNumberSmallerThanTheFirst,
            List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] <= firstSequenceNumber)
                {
                    lastNumberSmallerThanTheFirst = list[i];
                }
                else
                {
                    break;
                }
            }
            return lastNumberSmallerThanTheFirst;
        }

        static void AddToTheNewList(List<int> list, int lastNumberSmallerThanTheFirst, int[] sequence, int previousNum)
        {
            int currentNumber = 0;
            int lastIndex = 0;
            for (int i = 0; i < sequence.Length; i++)
            {
                currentNumber = sequence[i];
                lastNumberSmallerThanTheFirst = FindTheBiggestSmallNum(currentNumber, lastNumberSmallerThanTheFirst, list);
                int indexOfLastNum = list.LastIndexOf(lastNumberSmallerThanTheFirst);

                if (currentNumber < previousNum)
                {
                    list.Insert(lastIndex + 2, currentNumber);
                    RemoveAllElementsToTheEnd(currentNumber, list, sequence);
                    break;
                }
                lastIndex = indexOfLastNum;
                list.Insert(indexOfLastNum + 1, currentNumber);
                previousNum = currentNumber;
            }
        }

        static void RemoveAllElementsToTheEnd(int currentNumber, List<int> list, int[] sequence)
        {
            int index = list.LastIndexOf(currentNumber);

            for (int i = index; i < list.Count; i++)
            {
                list.RemoveAt(i);
                i--;
            }
        }
    }
}