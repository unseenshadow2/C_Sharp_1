using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3._2
{
    public class Player
    {
        private string name = "Requires Entry";
        private int number = 0;
        private List<int> points = new List<int>();

        public int games { get { return points.Count; } } // The number of games a player has played

        public override string ToString()
        {
            return name + " #" + number.ToString("D2");
        }

        // Getters and setters
        public string getName { get { return name; } }
        public string setName { set { name = value; } }

        public int getNumber { get { return number; } }
        public int setNumber { set { number = value; } }

        public List<int> getPoints { get { return points; } }
    }
}
