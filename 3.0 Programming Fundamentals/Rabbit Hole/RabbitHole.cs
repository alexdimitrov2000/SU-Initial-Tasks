using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabbit_Hole
{
    class RabbitHole
    {
        static void Main(string[] args)
        {
            List<string> obstaclesToOvercome = Console.ReadLine().Split(' ').ToList();
            int myInitialEnergy = int.Parse(Console.ReadLine());
            
            int position = 0;
            int size = obstaclesToOvercome.Count - 1;

            while (myInitialEnergy > 0)
            {
                string[] seperatedString = obstaclesToOvercome[position].Split('|');
                if (seperatedString[0] == "RabbitHole")
                {
                    Console.WriteLine("You have 5 years to save Kennedy!");
                    break;
                }
                switch (seperatedString[0])
                {
                    case "Right":
                        position = (position + int.Parse(seperatedString[1])) % obstaclesToOvercome.Count;
                        myInitialEnergy -= int.Parse(seperatedString[1]);

                        break;
                    case "Left":
                        position = (Math.Abs(position - int.Parse(seperatedString[1]))) % obstaclesToOvercome.Count;
                        myInitialEnergy -= int.Parse(seperatedString[1]);

                        break;
                    case "Bomb":
                        obstaclesToOvercome.RemoveAt(position);
                        position = 0;
                        myInitialEnergy -= int.Parse(seperatedString[1]);

                        break;
                }
                
                if (obstaclesToOvercome[size] != "RabbitHole")
                {
                    obstaclesToOvercome.RemoveAt(size);
                }
                obstaclesToOvercome.Add($"Bomb|{myInitialEnergy}");
                if (myInitialEnergy <= 0)
                {
                    if (seperatedString[0] == "Bomb")
                    {
                        Console.WriteLine("You are dead due to bomb explosion!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You are tired. You can't continue the mission.");
                        break;
                    }
                }
            }
        }
    }
}