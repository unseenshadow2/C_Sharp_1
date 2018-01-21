using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2._2
{
    public class Flavor
    {
        private string _name = "";
        private decimal[] _prices;

        private Flavor() {}
        public Flavor(string name, decimal[] prices)
        {
            _name = name;
            _prices = prices;
        }

        // Getters and setters
        public string getName { get { return _name; } }
        public string setName { set { _name = value; } }

        public decimal[] getPrices { get { return _prices; } }
        public decimal[] setPrices { set { _prices = value; } }
    }
}
