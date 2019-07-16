using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Lilly
{
    class SmartLilly
    {
        static void Main(string[] args)
        {
            var LillyYears = int.Parse(Console.ReadLine());
            var machinePrice = double.Parse(Console.ReadLine());
            var toyPrice = int.Parse(Console.ReadLine());

            var BDmoney = 10.00;
            var numberToys = 0;
            var savedMoney = 0.0;
            var moneySum = 0.0;
            var difference = 0.0;

            for (int years = 1; years <= LillyYears; years++)
            {
                if (years % 2 == 0)
                {
                    savedMoney = savedMoney + BDmoney - 1.00;
                    BDmoney += 10.00;
                }
                else
                {
                    numberToys++;
                }
            }

            moneySum = savedMoney + numberToys * toyPrice;

            if (moneySum >= machinePrice)
            {
                difference = moneySum - machinePrice;
                Console.WriteLine($"Yes! {difference:F2}");
            }
            else
            {
                difference = machinePrice - moneySum;
                Console.WriteLine($"No! {difference:F2}");
            }
        }
    }
}
