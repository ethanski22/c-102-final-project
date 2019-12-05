using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{
    class blackjackhand
    {
        List<Card> cards = new List<Card>();
        //public int playerpoints = 0;
        //public int aipoints = 0;
        public int points()
        {
            int playerpoints = 0;
            int aipoints = 0;
            foreach (Card c in cards)
            {
                if (val == 1)
                {
                    playerpoints = acevalue + playerpoints;
                }
                playerpoints = playerpoints + c.value;
                if(playerpoints == 21)
                {
                    winlose.Visible = True;
                    winlose.Text = "win";
                }
                else if(playerpoints < 21 & (aipoints < playerpoints || aipoints > 21))
                {
                    winlose.Visible = True;
                    winlose.Text = "win";
                }
                else if (playerpoints > 21)
                {
                    winlose.Visible = True;
                    winlose.Text = "lose";
                }
                else if (playerpoints < 21 & aipoints > playerpoints & aipoints < 21)
                {
                    winlose.Visible = True;
                    winlose.Text = "lose";
                }
                else if(playerpoints < 21 & aipoints == 21)
                {
                    winlose.Visible = True;
                    winlose.Text = "lose";
                }
            }
            return playerpoints;
            return aipoints;
        }
    }
}
