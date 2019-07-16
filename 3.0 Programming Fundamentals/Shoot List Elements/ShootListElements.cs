using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoot_List_Elements
{
    class ShootListElements
    {
        static void Main(string[] args)
        {
            List<double> numbersList = new List<double>();

            string input = Console.ReadLine();
            double lastRemovedInt = 0.0;
            bool mustBreak = false;
            string lastCommand = string.Empty;

            do
            {
                if (input == "bang")
                {
                    double average = numbersList.Average();

                    for (int i = 0; i < numbersList.Count; i++)
                    {
                        lastRemovedInt = numbersList[i];

                        if (numbersList[i] <= average)
                        {
                            Console.WriteLine($"shot {numbersList[i]}");
                            numbersList.RemoveAt(i);
                            for (int j = 0; j < numbersList.Count; j++)
                            {
                                numbersList[j]--;
                            }
                            break;
                        }
                    }
                }
                else if (input == "stop")
                {
                    break;
                }
                else
                {
                    double number = double.Parse(input);
                    numbersList.Insert(0, number);
                }
                input = Console.ReadLine();
                lastCommand = input;
            } while (numbersList.Count != 0);

            if (lastCommand != "stop")
            {
                Console.WriteLine($"nobody left to shoot! last one was {lastRemovedInt}");
            }
            else
            {
                if (numbersList.Count == 0)
                {
                    Console.WriteLine($"you shot them all. last one was {lastRemovedInt}");
                }
                else
                {
                    string outPrint = string.Join(" ", numbersList);
                    Console.WriteLine($"survivors: {outPrint}");
                }
            }
        }
    }
}
