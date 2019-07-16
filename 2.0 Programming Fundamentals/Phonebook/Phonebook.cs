using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Phonebook
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(' ').ToArray();
            string[] names = Console.ReadLine().Split(' ').ToArray();

            string contact = string.Empty;
            string contactNumber = string.Empty;

            while (contact != "done")
            {
                contact = Console.ReadLine();

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (contact == names[i])
                    {
                        contactNumber = numbers[i];

                        Console.WriteLine($"{names[i]} -> {numbers[i]}");
                    }
                }
            }
        }
    }
}
