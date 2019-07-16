using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiles_Repair
{
    class TilesRepair
    {
        static void Main(string[] args)
        {
            var playgroundLenght = double.Parse(Console.ReadLine());
            var tileWidth = double.Parse(Console.ReadLine());
            var tileLenght = double.Parse(Console.ReadLine());
            var benchWidth = double.Parse(Console.ReadLine());
            var benchLenght = double.Parse(Console.ReadLine());

            var groundArea = Math.Pow(playgroundLenght, 2);
            var benchArea = benchLenght * benchWidth;
            var tileArea = tileLenght * tileWidth;
            var timeForTile = 0.2;

            var finalArea = groundArea - benchArea;

            var necessaryTiles = finalArea / tileArea;

            var necessaryTime = necessaryTiles * timeForTile;

            Console.WriteLine(necessaryTiles);
            Console.WriteLine(necessaryTime);
        }
    }
}
