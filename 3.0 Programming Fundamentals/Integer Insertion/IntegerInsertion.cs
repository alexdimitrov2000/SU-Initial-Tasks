using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer_Insertion
{
    class IntegerInsertion
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string stringNumber = Console.ReadLine();

            while (stringNumber != "end")
            {
                char[] digits = stringNumber.ToCharArray();
                int firstDigit = Convert.ToInt32(digits[0] - '0');
                int index = firstDigit;
                int number = int.Parse(stringNumber);

                list.Insert(index, number);

                stringNumber = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
