using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello__Name___Methods_
{
    class Program
    {
        static void Main(string[] args)
        {
            string ime = Console.ReadLine();

            Console.WriteLine("Hello, {0}!", GetName(ime));
        }

        static string GetName(string name)
        {
            return name;
        }
    }
}
