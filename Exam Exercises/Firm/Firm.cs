using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firm
{
    class Firm
    {
        static void Main(string[] args)
        {
            var hoursNeeded = int.Parse(Console.ReadLine());
            var daysHave = int.Parse(Console.ReadLine());
            var numberOfEmployees = int.Parse(Console.ReadLine());

            var daysTraining = daysHave * 0.10;
            var leftDays = daysHave - daysTraining;
            var leftHours = leftDays * 8;

            var overtimeWorkingHours = numberOfEmployees * 2 * 7;
            var summedHours = Math.Floor(overtimeWorkingHours + leftHours);
            var result = Math.Abs(summedHours - hoursNeeded);

            if (summedHours >= hoursNeeded)
            {
                var remainingHours = Math.Floor(summedHours - hoursNeeded);

                Console.WriteLine("Yes!{0} hours left.", result);
            }
            else
            {
                Console.WriteLine("Not enough time!{0} hours needed.", result);
            }
            //not working
        }
    }
}
