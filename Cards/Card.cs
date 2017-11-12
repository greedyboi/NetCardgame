using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    public enum CardNumber
    {
        DEUX,
        TROIS,
        QUATRE,
        CINQ,
        SIX,
        SEPT,
        HUIT,
        NEUF,
        DIX,
        VALET,
        DAME,
        ROI,
        AS,
    }

    public enum CardType
    {
        COEUR,
        CARREAU,
        PIQUE,
        TREFLE,
    }
    public class Card
    {
        public Card(CardNumber num, CardType type)
        {
            n = num;
            t = type;
        }
        private CardNumber n { get; set; }
        private CardType t { get; set; }
    }
}
