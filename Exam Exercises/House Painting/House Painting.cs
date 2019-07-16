using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Painting
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());

            var backWall = x * x;
            var frontWall = backWall - (1.2 * 2);
            var sideWalls = (x * y - 1.5 * 1.5) * 2;
            var walls = backWall + frontWall + sideWalls;

            var sideRoofParts = 2 * (x * y);
            var roofTriangle = ((x * h) / 2) * 2;
            var roof = sideRoofParts + roofTriangle;

            var greenPaint = walls / 3.4;
            var redPaint = roof / 4.3;

            Console.WriteLine($"{greenPaint:f2}");
            Console.WriteLine($"{redPaint:f2}");
        }
    }
}
