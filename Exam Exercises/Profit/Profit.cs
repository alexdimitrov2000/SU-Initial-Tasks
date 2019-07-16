using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profit
{
    class Profit
    {
        static void Main(string[] args)
        {
            var monthDays = int.Parse(Console.ReadLine());
            var moneyForaDay = double.Parse(Console.ReadLine());
            var dolarCourse = double.Parse(Console.ReadLine());

            var monthSalary = monthDays * moneyForaDay;
            var yearIncome = monthSalary * 12 + monthSalary * 2.5;
            var tax = yearIncome * 25 / 100;
            var pureProfitinDolars = yearIncome - tax;

            var pureProfitInLevs = pureProfitinDolars * dolarCourse;
            var result = pureProfitInLevs / 365;

            Console.WriteLine("{0:F2}", result);
        }
    }
}
