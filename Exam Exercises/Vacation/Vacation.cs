using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation
{
    class Vacation
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string accomodation;
            string location;
            var spentMoney = 0.0;

            if (budget <= 1000)
            {
                accomodation = "Camp";

                if (season == "Summer")
                {
                    location = "Alaska";
                    spentMoney = budget * 0.65;
                }
                else
                {
                    location = "Morocco";
                    spentMoney = budget * 0.45;
                }

            }
            else if (budget > 1000 && budget <= 3000)
            {
                accomodation = "Hut";

                if (season == "Summer")
                {
                    location = "Alaska";
                    spentMoney = budget * 0.80;
                }
                else
                {
                    location = "Morocco";
                    spentMoney = budget * 0.60;
                }
            }
            else
            {
                accomodation = "Hotel";

                if (season == "Summer")
                {
                    location = "Alaska";
                    spentMoney = budget * 0.90;
                }
                else
                {
                    location = "Morocco";
                    spentMoney = budget * 0.90;
                }
            }

            Console.WriteLine($"{location} - {accomodation} - {spentMoney:f2}");
        }
    }
}
