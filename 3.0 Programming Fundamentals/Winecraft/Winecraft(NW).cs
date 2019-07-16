using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winecraft
{
    class Winecraft
    {
        static int[] grapes;
        static void Main(string[] args)
        {
            grapes = Console.ReadLine().Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());

            do
            {
                for (int i = 0; i < n; i++)
                {
                    PlantBloom();
                }
                KillUnnecessaryGrapes(n);

            } while (ShouldRepeat(n));

            PrintAliveGrapes();
        }

        static void PlantBloom()
        {
            for (int i = 0; i < grapes.Length; i++)
            {
                if (!IsAlive(i))
                {
                    continue;
                }

                if (IsGreater(i))
                {
                    grapes[i]++;
                    if (IsAlive(i - 1))
                    {
                        grapes[i]++;
                        grapes[i - 1]--;
                    }
                    if (IsAlive(i + 1))
                    {
                        grapes[i]++;
                        grapes[i + 1]--;
                    }
                }
                else
                {
                    grapes[i]++;
                }
            }
        }

        static bool IsGreater(int index)
        {
            if (index <= 0 || index >= (grapes.Length - 1))
            {
                return false;
            }
            return (grapes[index] > grapes[index - 1] && grapes[index] > grapes[index + 1]);
        }

        static bool IsLesser(int index)
        {
            return (IsGreater(index - 1) || IsGreater(index + 1));
        }

        static bool ShouldRepeat(int n)
        {
            int plantsHealthBiggerThanN = 0;

            for (int i = 0; i < grapes.Length; i++)
            {
                if (grapes[i] > n)
                {
                    plantsHealthBiggerThanN++;
                }
            }

            return (plantsHealthBiggerThanN >= n);
        }

        static void KillUnnecessaryGrapes(int n)
        {
            for (int i = 0; i < grapes.Length; i++)
            {
                if (grapes[i] <= n)
                {
                    grapes[i] = 0;
                }
            }
        }

        static void PrintAliveGrapes()
        {
            for (int i = 0; i < grapes.Length; i++)
            {
                if (IsAlive(i))
                {
                    Console.Write(grapes[i] + " ");
                }
            }
            Console.WriteLine();
        }

        static bool IsAlive(int index)
        {
            if (index < 0 || index >= grapes.Length)
            {
                return false;
            }

            return grapes[index] > 0;
        }

        // 44/100 ?
    }
}
