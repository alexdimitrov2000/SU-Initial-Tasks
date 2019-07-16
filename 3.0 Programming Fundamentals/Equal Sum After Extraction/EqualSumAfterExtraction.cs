using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Sum_After_Extraction
{
    class EqualSumAfterExtraction
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int sumOfFirstList = 0;
            int sumFromSecondList = 0;

            for (int i = 0; i < firstList.Count; i++)
            {
                for (int j = 0; j < secondList.Count; j++)
                {
                    if (firstList[i] == secondList[j])
                    {
                        secondList.RemoveAt(j);
                    }
                }
                sumOfFirstList += firstList[i];
            }

            for (int i = 0; i < secondList.Count; i++)
            {
                sumFromSecondList += secondList[i];
            }

            if (sumOfFirstList == sumFromSecondList)
            {
                Console.WriteLine($"Yes. Sum: {sumOfFirstList}");
            }
            else
            {
                Console.WriteLine($"No. Diff: {Math.Abs(sumFromSecondList - sumOfFirstList)}");
            }
        }
    }
}
