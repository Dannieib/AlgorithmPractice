using System;
using System.Collections.Generic;

namespace TournamentWinner
{
    /*
     * 
       There's an algorithms tournament taking place in which teams of programmers
       compete against each other to solve algorithmic problems as fast as possible.
       Teams compete in a round robin, where each team faces off against all other
       teams. Only two teams compete against each other at a time, and for each
       competition, one team is designated the home team, while the other team is the
       away team. In each competition there's always one winner and one loser; there
       are no ties. A team receives 3 points if it wins and 0 points if it loses. The
       winner of the tournament is the team that receives the most amount of points.


     */
    class Program
    {
        static void Main(string[] args)
        {
            var competitions = new List<List<string>>
            {
                new List<string>
                {
                    "HTML", "C#"
                },
                new List<string>
                {
                    "C#", "Python",
                },
                new List<string>
                {
                    "Python", "HTML"
                }
            };
            var results = new List<int>{0, 0, 1};

            Console.WriteLine(TournamentWinner(competitions,results));

            Console.ReadKey();
        }

        static string TournamentWinner(List<List<string>> competitions, List<int> results)
        {
            var scores = new Dictionary<string, int>();//hashtable
            var bestWinningTeam = "";
            scores[bestWinningTeam] = 0;

            for (int i = 0; i < competitions.Count; i++)
            {
                var competition = competitions[i];
                var result = results[i];
                var teamA = competition[0];
                var teamB = competition[1];

                var newBestWinningTeam = (result ==1)?teamA:teamB;

                if (!scores.ContainsKey(newBestWinningTeam))
                {
                    scores[newBestWinningTeam] = 0;
                }

                scores[newBestWinningTeam] = scores[newBestWinningTeam] + 3;

                if (scores[newBestWinningTeam] > scores[bestWinningTeam])
                {
                    bestWinningTeam = newBestWinningTeam;
                }
            }
            return bestWinningTeam;
        }
    }
}
