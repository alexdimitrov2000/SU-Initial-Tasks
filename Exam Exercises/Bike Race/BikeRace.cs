using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bike_Race
{
    class BikeRace
    {
        static void Main(string[] args)
        {
            var numberJuniorRacers = int.Parse(Console.ReadLine());
            var numberSeniorRacers = int.Parse(Console.ReadLine());
            string route = Console.ReadLine();

            var juniorsMoney = 0.0;
            var seniorsMoney = 0.0;

            if (route == "trail")
            {
                juniorsMoney = 5.50;
                seniorsMoney = 7.0;
            }
            else if (route == "cross-country")
            {
                juniorsMoney = 8.00;
                seniorsMoney = 9.50;
                if (numberJuniorRacers + numberSeniorRacers >= 50)
                {
                    juniorsMoney = juniorsMoney - juniorsMoney * 0.25;
                    seniorsMoney = seniorsMoney - seniorsMoney * 0.25;
                }
            }
            else if (route == "downhill")
            {
                juniorsMoney = 12.25;
                seniorsMoney = 13.75;
            }
            else if (route == "road")
            {
                juniorsMoney = 20.00;
                seniorsMoney = 21.50;
            }

            var madeMoney = juniorsMoney * numberJuniorRacers + seniorsMoney * numberSeniorRacers;
            var afterTaxes = madeMoney - madeMoney * 0.05;

            Console.WriteLine($"{afterTaxes:f2}");
        }
    }
}
