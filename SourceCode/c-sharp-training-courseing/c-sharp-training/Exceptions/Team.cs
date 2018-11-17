using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_training.Exceptions
{


    public class Team
    {
        static int PlayerIndex = 0;
        public string Name { get; set; }
        public Player[] Players = new Player[5];

        public void AddPlayer(Player p)
        {
            try
            {
                if (p.Name.Length <= 5)
                {
                    throw new TeamException("Player Name cannot be less than 5 char");
                }
                Players[PlayerIndex] = new Player();
                Players[PlayerIndex] = p;
                PlayerIndex++;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }


        }
    }

}
