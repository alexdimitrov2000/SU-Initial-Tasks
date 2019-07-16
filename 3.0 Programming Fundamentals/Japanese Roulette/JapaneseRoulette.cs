using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Japanese_Roulette
{
    class JapaneseRoulette
    {
        static void Main(string[] args)
        {
            List<int> cylinder = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string[] shoots = Console.ReadLine().Split(' ').ToArray();
            int position = 0;
            bool playerIsDead = false;
            int bulletLocationIndex = 0;
            int muzzleIndex = 2;
            int moves = 0;

            for (int i = 0; i < cylinder.Count; i++)
            {
                if (cylinder[i] == 1)
                {
                    bulletLocationIndex = i;
                    break;
                }
            }

            while (true)
            {
                string[] tokens = shoots[position].Split(',').ToArray();
                int power = int.Parse(tokens[0]);
                string direction = tokens[1];


                switch (direction)
                {
                    case "Left":
                        if (bulletLocationIndex - power >= 0)
                        {
                            bulletLocationIndex = Math.Abs(bulletLocationIndex - power) % cylinder.Count;
                        }
                        else
                        {
                            bulletLocationIndex = cylinder.Count - (Math.Abs(bulletLocationIndex - power) % cylinder.Count);
                        }
                        break;
                    case "Right":
                        bulletLocationIndex = (bulletLocationIndex + power) % cylinder.Count;
                        break;
                }

                if (muzzleIndex == bulletLocationIndex)
                {
                    Console.WriteLine($"Game over! Player {moves} is dead.");
                    break;
                }
                moves++;
                if (moves == shoots.Length)
                {
                    if (!playerIsDead)
                    {
                        Console.WriteLine("Everybody got lucky!");
                        break;
                    }
                }

                if (bulletLocationIndex + 1 == cylinder.Count)
                {
                    bulletLocationIndex = 0;
                }
                else
                {
                    bulletLocationIndex++;
                }
                cylinder.Remove(1);
                cylinder.Insert(bulletLocationIndex, 1);
                position++;
            }
        }
    }
}
