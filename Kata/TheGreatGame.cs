using System.Collections.Generic;
using System.Linq;

namespace Kata
{
    public class TheGreatGame
    {
        // https://www.codewars.com/kata/553bee3d8234ef49fe000025/train/csharp
        // 6 kyu
        private enum GameResult
        {
            Team1Win,
            Team2Win,
            Tie
        }
        
        public string WhoIsWinner(string team1, string team2)
        {
            var roundResults = Play(team1, team2);

            return GetGameOverMessage(roundResults.ToList());
        }

        private static string GetGameOverMessage(List<GameResult> gameResults)
        {
            var timesOf1Win = gameResults.Count(x => x == GameResult.Team1Win);
            var timesOf2Win = gameResults.Count(x => x == GameResult.Team2Win);
            return timesOf1Win - timesOf2Win == 0 ? "TIE" : timesOf1Win > timesOf2Win ? "TEAM 1 WINS" : "TEAM 2 WINS";
        }

        private IEnumerable<GameResult> Play(string team1, string team2)
        {
            using(var actionsOfTeam1 = GetActions(team1).GetEnumerator())
            using(var actionsOfTeam2 = GetActions(team2).GetEnumerator())
            {
                while (actionsOfTeam1.MoveNext() && actionsOfTeam2.MoveNext())
                {
                    yield return GetRoundResult(actionsOfTeam1.Current, actionsOfTeam2.Current);
                }
            }
        }

        private IEnumerable<string> GetActions(string team)
        {
            var position = 0;
            while (team.Skip(position).Any())
            {
                yield return team.Substring(position, 2);
                position += 2;
            }
        }

        private GameResult GetRoundResult(string action1, string action2)
        {
            var actionDict = new Dictionary<string, int>()
            {
                {"()", 1},
                {"[]", 2},
                {"8<", 3},
            };

            var score1 = actionDict[action1];
            var score2 = actionDict[action2];
            if (score1 == 3 && score2 == 1)
            {
                return GameResult.Team2Win;
            }

            if (score1 == 1 && score2 == 3)
            {
                return GameResult.Team1Win;
            }

            return score1 == score2 ? GameResult.Tie : score1 > score2 ? GameResult.Team1Win : GameResult.Team2Win;
        }
    }

}