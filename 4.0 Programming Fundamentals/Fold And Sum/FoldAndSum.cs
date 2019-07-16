using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fold_And_Sum
{
    class FoldAndSum
    {
        static void Main(string[] args)
        {
            List<int> inputNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int k = inputNumbers.Count / 4;

            List<int> leftKNums = inputNumbers.Take(k).Reverse().ToList();
            inputNumbers.Reverse();
            List<int> rightKNums = inputNumbers.Take(k).ToList();
            inputNumbers.Reverse();

            List<int> upperNumbers = new List<int>();
            List<int> downNumbers = new List<int>();
            upperNumbers = leftKNums.Concat(rightKNums).ToList();
            downNumbers = inputNumbers.Skip(k).Take(2 * k).ToList();

            List<int> summedElements = new List<int>();

            for (int i = 0; i < upperNumbers.Count; i++)
            {
                summedElements.Add(upperNumbers[i] + downNumbers[i]);    
            }

            Console.WriteLine(string.Join(" ", summedElements));
        }
    }
}
