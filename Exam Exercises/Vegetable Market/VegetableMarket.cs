using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vegetable_Market
{
    class VegetableMarket
    {
        static void Main(string[] args)
        {
            var vegetablePrice = double.Parse(Console.ReadLine());
            var fruitPrice = double.Parse(Console.ReadLine());
            var vegetableKG = int.Parse(Console.ReadLine());
            var fruitKG = int.Parse(Console.ReadLine());

            var euro = 1.94;

            var vegetables = vegetablePrice * vegetableKG;
            var fruits = fruitPrice * fruitKG;

            var resultLevs = vegetables + fruits;
            var result = resultLevs / euro;
            Console.WriteLine(result);
        }
    }
}
