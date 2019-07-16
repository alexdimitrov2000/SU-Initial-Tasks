using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softuni_Beer_Pong
{
    class SoftuniBeerPong
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> teams = new Dictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();

            Dictionary<string, int> playerPoints = new Dictionary<string, int>();

            while (input != "stop the game")
            {
                string[] inputTokens = input.Split('|');
                string playerName = inputTokens[0];
                string team = inputTokens[1];
                int pointsMade = int.Parse(inputTokens[2]);

                if (!teams.ContainsKey(team))
                {
                    teams.Add(team, new Dictionary<string, int>());
                }
                if (teams[team].Values.Count < 3)
                {
                    teams[team].Add(playerName, pointsMade);
                }
                input = Console.ReadLine();
            }

            Dictionary<string, Dictionary<string, int>> finalTeams =
                teams
                .Where(w => w.Value.Count == 3)
                .OrderByDescending(w => w.Value.Values.Sum())
                    .ToDictionary(k => k.Key, v => v.Value);

            int numberOfTeam = 0;
            foreach (var finalTeamPair in finalTeams)
            {
                numberOfTeam++;
                Dictionary<string, int> dictOfPlayerPoints = finalTeamPair.Value
                    .OrderByDescending(w => w.Value)
                    .ToDictionary(k => k.Key, v => v.Value);
                Console.WriteLine($"{numberOfTeam}. {finalTeamPair.Key}; Players:");
                foreach (var playerPointsPair in dictOfPlayerPoints)
                {
                    Console.WriteLine($"###{playerPointsPair.Key}: {playerPointsPair.Value}");
                }
            }
        }
    }
}
