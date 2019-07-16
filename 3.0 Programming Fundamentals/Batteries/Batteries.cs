using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batteries
{
    class Batteries
    {
        static void Main(string[] args)
        {
            double[] batteryCapacity = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double[] usagePerHour = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            int amountOfStressTestHours = int.Parse(Console.ReadLine());
            int stressTestHours = amountOfStressTestHours;

            double drain = 0.0;
            int lastedHours = 0;

            for (int i = 0; i < batteryCapacity.Length; i++)
            {
                double capacityAtFirst = batteryCapacity[i];
                drain = usagePerHour[i];
                amountOfStressTestHours = stressTestHours;
                lastedHours = 0;

                while ((batteryCapacity[i] > 0) && (amountOfStressTestHours > 0))
                {
                    batteryCapacity[i] -= drain;
                    amountOfStressTestHours--;
                    lastedHours++;
                }

                if (batteryCapacity[i] > 0)
                {
                    double percentage = ((double)batteryCapacity[i] / (double)capacityAtFirst) * 100;

                    Console.WriteLine($"Battery {i + 1}: {batteryCapacity[i]:f2} mAh ({percentage:F2})%");
                }
                else
                {
                    Console.WriteLine($"Battery {i + 1}: dead (lasted {lastedHours} hours)");
                }
            }
        }
    }
}
