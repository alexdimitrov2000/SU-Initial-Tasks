using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Symmetry
{
    class ArraySymmetry
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(' ').ToArray();
            bool equals = false;
            
            for (int i = 0; i <= (text.Length - 1) / 2; i++)
            {
                if (text[i] != text[text.Length - 1 - i])
                {
                    equals = false;
                    break;
                }
                else
                {
                    equals = true;
                }
            }

            if (equals == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            
        }
    }
}
