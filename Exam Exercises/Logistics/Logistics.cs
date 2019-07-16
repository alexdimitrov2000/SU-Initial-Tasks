using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics
{
    class Logistics
    {
        static void Main(string[] args)
        {
            var numberOfLoads = int.Parse(Console.ReadLine());
            var loadTons = 0;
            var totalLoads = 0.0;
            var firstGroup = 0.0;
            var secondGroup = 0.0;
            var thirdGroup = 0.0;
            var averagePriceOnTon = 0.0;
            var percentLoadsTransportedWithBus = 0.0;
            var percentLoadsTransportedWithLorry = 0.0;
            var percentLoadsTransportedWithTrain = 0.0;

            for (int i = 1; i <= numberOfLoads; i++)
            {
                loadTons = int.Parse(Console.ReadLine());

                if (loadTons <= 3)
                {
                    firstGroup+=loadTons;
                }
                else if (loadTons >= 4 && loadTons <= 11)
                {
                    secondGroup+=loadTons;
                }
                else
                {
                    thirdGroup+= loadTons;
                }
                totalLoads += loadTons;

            }
            averagePriceOnTon = (firstGroup * 200.00 + secondGroup * 175.00 + thirdGroup * 120.00) / totalLoads;
            percentLoadsTransportedWithBus = (firstGroup / totalLoads) *100.00;
            percentLoadsTransportedWithLorry = (secondGroup / totalLoads) * 100.00;
            percentLoadsTransportedWithTrain = (thirdGroup / totalLoads) * 100.00;

            Console.WriteLine($"{averagePriceOnTon:f2}");
            Console.WriteLine($"{percentLoadsTransportedWithBus:f2}%");
            Console.WriteLine($"{percentLoadsTransportedWithLorry:f2}%");
            Console.WriteLine($"{percentLoadsTransportedWithTrain:f2}%");
        }
    }
}
