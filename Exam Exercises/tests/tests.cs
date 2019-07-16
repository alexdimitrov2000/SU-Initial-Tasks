using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            for (int i = 0; i < number - 2; i++)
            {
                Console.WriteLine("*{0}*", new string(' ', number - 2));
            }


            for (int i = 0; i < number; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}