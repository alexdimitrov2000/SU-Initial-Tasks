using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butterfly
{
    class Butterfly
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var stars = n - 2;
            var dashes = stars;
            var rows = 2 * (n - 2) + 1;
            if (!(n >=3 && n <=1000))
            {
                Console.WriteLine("Error");
            }
            else
            {
                for (int row = 1; row <= rows; row++)
                {
                    if (row < n-1)
                    {
                        if (row % 2 == 0)
                        {
                            Console.Write(new string('-', stars));
                            Console.Write('\\');
                            Console.Write(' ');
                            Console.Write('/');
                            Console.WriteLine(new string('-', stars));
                        }

                        else
                        {
                            Console.Write(new string('*', stars));
                            Console.Write('\\');
                            Console.Write(' ');
                            Console.Write('/');
                            Console.WriteLine(new string('*', stars));
                        }
                    }
                    else if (row == n - 1)
                    {
                        Console.Write(new string(' ', n - 1));
                        Console.WriteLine("@");
                    }
                    else
                    {
                        if (row % 2 == 0)
                        {
                            Console.Write(new string('-', stars));
                            Console.Write('/');
                            Console.Write(' ');
                            Console.Write('\\');
                            Console.WriteLine(new string('-', stars));
                        }

                        else
                        {
                            Console.Write(new string('*', stars));
                            Console.Write('/');
                            Console.Write(' ');
                            Console.Write('\\');
                            Console.WriteLine(new string('*', stars));
                        }
                    }
                }
            }
        }
    }
}
