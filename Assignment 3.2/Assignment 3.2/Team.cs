using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3._2
{
    public class Team
    {
        private Player[] players = new Player[11];

        public int games { get { return players[0].games; } }

        // Fill our player array at the start
        public Team()
        {
            for (int i = 0; i < players.Length; i++) players[i] = new Player();
        }

        // Getters and setters
        public Player[] getPlayers { get { return players; } }
    }
}
