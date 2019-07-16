using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Power_Plants
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] plantsLifes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int deadPlants = 0;
            int plantIndex = 0;
            int dayN = 0;
            int daysSurvived = 0;
            for (int i = 0; i < plantsLifes.Length; i++)
            {
                plantIndex = 0;
                deadPlants = 0;
                for (int j = 0; j < plantsLifes.Length; j++)
                {
                    if (i == plantIndex)
                    {
                        plantsLifes[j] = plantsLifes[j];

                    }
                    else
                    {
                        if (plantsLifes[j] == 0)
                        {
                            plantsLifes[j] = plantsLifes[j];
                        }
                        else
                        {
                            plantsLifes[j]--;
                        }
                    }

                    if (plantsLifes[j] == 0)
                    {
                        deadPlants++;
                    }
                    plantIndex++;
                }
                dayN = i;
                daysSurvived++;

                if (dayN + 1 == plantsLifes.Length)
                {
                    i = -1;
                    for (int j = 0; j < plantsLifes.Length; j++)
                    {
                        if (plantsLifes[j] == 0)
                        {
                            plantsLifes[j] = 0;
                        }
                        else
                        {
                            plantsLifes[j]++;
                        }
                    }
                }

                if (deadPlants == plantsLifes.Length)
                {
                    break;
                }
            }
            string seasonOuput = string.Empty;
            long seasons = daysSurvived / plantsLifes.Length;
            if (daysSurvived % plantsLifes.Length == 0)
            {
                seasons -= 1;
            }
            if (seasons == 1)
            {
                seasonOuput = "1 season";
            }
            else
            {
                seasonOuput = $"{seasons} seasons";
            }
            Console.WriteLine($"survived {daysSurvived} days ({seasonOuput})");
        }
    }
}