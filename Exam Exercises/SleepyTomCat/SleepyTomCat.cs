using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleepyTomCat
{
    class SleepyTomCat
    {
        static void Main(string[] args)
        {
            var numberOfFreeDays = int.Parse(Console.ReadLine());

            var daysInYear = 365;
            var normTimeForPlay = 30000;
            var minutesPerDay = 0;

            var minutesWhenIsOnWork = 63;
            var minutesWhenFree = 127;

            var workDays = daysInYear - numberOfFreeDays;

            var timeForPlay = workDays * minutesWhenIsOnWork + numberOfFreeDays * minutesWhenFree;

            var difference = 0;
            var hours = 0;
            var minutes = 0;

            if (normTimeForPlay > timeForPlay)
            {
                difference = normTimeForPlay - timeForPlay;
                hours = difference / 60;
                minutes = difference % 60;

                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
            }
            else
            {
                difference = timeForPlay - normTimeForPlay;
                hours = difference / 60;
                minutes = difference % 60;

                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
            }
        }
    }
}
