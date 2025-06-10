using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>();

            players.Add(new Player("Mohamed"));
            players.Add(new Player("Hatim"));
            players.Add(new Player("Tai"));

            foreach (Player p in players) {
                Console.WriteLine(p);
                // Console.WriteLine(p.username);
            }

            Console.ReadKey();
        }
    }

    class Player
    {
        public string username;

        public Player(string username)
        {
            this.username = username;
        }

        public override string ToString()
        {
            return username;
        }
    }
}
