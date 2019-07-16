using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotate_Array_Of_Strings
{
    class RotateArrayOfStrings
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] resultArray = new string[array.Length];

            for (int i = 0; i < array.Length - 1; i++)
            {
                resultArray[i + 1] = array[i];
            }
            resultArray[0] = array[array.Length - 1];

            Console.WriteLine(string.Join(" ", resultArray));
        }
    }
}
