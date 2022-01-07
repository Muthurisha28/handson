using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace player
{

    class Player
    {
        public string Name { get; set; }
        public string Team { get; set; }
        public int Score { get; set; }
    }
    class PlayerImplementation
    {
        public int Average(IList<Player> players)
        {
            var result = players.Average(player => player.Score);
            Console.WriteLine();
            return Convert.ToInt32(result);
        }
        public int Max(IList<Player> players)
        {
            //int result = players.Max(player => player.Score);
            //return result;
            if (players.Count == 0)
            {
                throw new InvalidOperationException("Empty list");
            }
            int maxScore = int.MinValue;
            foreach (Player type in players)
            {
                if (type.Score > maxScore)
                {
                    maxScore = type.Score;
                }
            }
            return maxScore;
        }
        public int Min(IList<Player> players)
        {
            //var result = players.Min(player => player.Score);
            //return result;
            if (players.Count == 0)
            {
                throw new InvalidOperationException("Empty list");
            }
            int minScore = int.MaxValue;
            foreach (Player type in players)
            {
                if (minScore>type.Score)
                {
                    minScore = type.Score;
                }
            }
            return minScore;
        }
    }
}

       