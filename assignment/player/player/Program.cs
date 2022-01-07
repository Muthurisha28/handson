using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace player
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1
            IList<Player> players = new List<Player>();
            players.Add(new Player { Name = "X", Team = "A", Score = 30 });
            players.Add(new Player { Name = "y", Team = "A", Score = 50 });
            players.Add(new Player { Name = "z", Team = "A", Score = 10 });
            players.Add(new Player { Name = "X", Team = "A", Score = 70 });
            players.Add(new Player { Name = "X", Team = "A", Score = 5 });
            PlayerImplementation playerImplementation = new PlayerImplementation();
            Console.WriteLine(playerImplementation.Average(players));
            Console.WriteLine(playerImplementation.Max(players));
            Console.WriteLine(playerImplementation.Min(players));
            Console.ReadKey();
            //task 2
           /* string[] inputs = { "test2", "test1" };
            Program p = new Program();
            p.SENTINEL = "~";
            p.JoinIt(inputs);
            p.SplitIt("test");
            p.Reverse("test");
            p.PadLeft("test", 2, 'a'); */

        }
    }
}
