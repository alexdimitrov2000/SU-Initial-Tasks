using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cups
{
    class Cups
    {
        static void Main(string[] args)
        {
            var predictedNumberOfCups = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());
            var workDays = int.Parse(Console.ReadLine());

            var workingHoursADay = 8;

            var workTime = workers * workingHoursADay * workDays;
            var producedCups = Math.Floor(workTime / 5.0);

            if (producedCups >= predictedNumberOfCups)
            {
                var result = producedCups - predictedNumberOfCups;
                var profit = result * 4.20;
                Console.WriteLine($"{profit:f2} extra money");
            }
            else
            {
                var result = predictedNumberOfCups - producedCups;
                var loses = result * 4.20;
                Console.WriteLine($"Losses: {loses:f2}");
            }
        }
    }
}
