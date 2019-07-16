using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flower_Shop
{
    class FlowerShop
    {
        static void Main(string[] args)
        {
            var magnolii = int.Parse(Console.ReadLine());
            var zuimbuili = int.Parse(Console.ReadLine());
            var rozi = int.Parse(Console.ReadLine());
            var kaktusi = int.Parse(Console.ReadLine());
            var giftPrice = double.Parse(Console.ReadLine());

            var magnoliiPrice = 3.25;
            var zumbuliPrice = 4.00;
            var roziPrice = 3.50;
            var kaktusiPrice = 8.00;

            var flowersPrice = magnolii * magnoliiPrice + zuimbuili * zumbuliPrice + rozi * roziPrice + kaktusi * kaktusiPrice;

            var final = flowersPrice - flowersPrice * 0.05;

            if (giftPrice > final)
            {
                var result = Math.Ceiling(giftPrice - final);
                Console.WriteLine($"She will have to borrow {result} leva.");
            }
            else
            {
                var result =Math.Floor( final - giftPrice);
                Console.WriteLine($"She is left with {result} leva.");
            }
        }
    }
}
