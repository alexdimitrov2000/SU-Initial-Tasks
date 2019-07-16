using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Price
{
    class HousePrice
    {
        static void Main(string[] args)
        {
            var smallestRoomArea = double.Parse(Console.ReadLine());
            var kitchenArea = double.Parse(Console.ReadLine());
            var squareMeterPrice = double.Parse(Console.ReadLine());

            var bathArea = smallestRoomArea / 2;
            var secondRoomArea = smallestRoomArea + smallestRoomArea * 0.10;
            var thirdRoomArea = secondRoomArea + secondRoomArea * 0.10;

            var totalArea = smallestRoomArea + kitchenArea + bathArea + secondRoomArea + thirdRoomArea;
            var finalArea = totalArea + totalArea * 0.05;

            var price = squareMeterPrice * finalArea;

            Console.WriteLine($"{price:f2}");
        }
    }
}
