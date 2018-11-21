using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_training.Collection
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Team
    {
        //Player[] Players = new Player[3];

        List<Player> Players = new List<Player>();
        ArrayList arr = new ArrayList(); 

        public void AddPlayer(Player p)
        {
            Players.Add(p);
        }

        public void PrintPlayerDetails()
        {
            foreach(Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }

    }
}
