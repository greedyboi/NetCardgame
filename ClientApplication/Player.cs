using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cards;

namespace Players
{
    public class Player
    {
        public Player(String _name)
        {
            this.name = _name;
       
        }
        private String name { get; set; }
        private List<Card> cards;
    }
}
