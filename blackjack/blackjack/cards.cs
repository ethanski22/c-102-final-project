using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{
    class cards
    {
        public int makerandomcard()
        {
            List<int> listcards = new List<int>();
            Random rnd = new Random();
            int card = rnd.Next(1, 52);
            for (int i = 0; i < 10; i++)
            {
                listcards.Add(card);
                card = rnd.Next(1, 52);
                if(card == 1)
                {
                    //A❤
                }
                if (card == 2)
                {
                    //2❤
                }
                if (card == 3)
                {
                    //3❤
                }
                if (card == 4)
                {
                    //4❤
                }
                if (card == 5)
                {
                    //5❤
                }
                if (card == 6)
                {
                    //6❤
                }
                if (card == 7)
                {
                    //7❤
                }
                if (card == 8)
                {
                    //8❤
                }
                if (card == 9)
                {
                    //9❤
                }
                if (card == 10)
                {
                    //10❤
                }
                if (card == 11)
                {
                    //J❤
                }
                if (card == 12)
                {
                    //Q❤
                }
                if (card == 13)
                {
                    //K❤
                }
                if (card == 14)
                {
                    //A◆
                }
                if (card == 15)
                {
                    //2◆
                }
                if (card == 16)
                {
                    //3◆
                }
                if (card == 17)
                {
                    //4◆
                }
                if (card == 18)
                {
                    //5◆
                }
                if (card == 19)
                {
                    //6◆
                }
                if (card == 20)
                {
                    //7◆
                }
                if (card == 21)
                {
                    //8◆
                }
                if (card == 22)
                {
                    //9◆
                }
                if (card == 23)
                {
                    //10◆
                }
                if (card == 24)
                {
                    //J◆
                }
                if (card == 25)
                {
                    //Q◆
                }
                if (card == 26)
                {
                    //K◆
                }
                if (card == 27)
                {
                    //A♠️
                }
                if (card == 28)
                {
                    //2♠️
                }
                if (card == 29)
                {
                    //3♠️
                }
                if (card == 30)
                {
                    //4♠️
                }
                if (card == 31)
                {
                    //5♠️
                }
                if (card == 32)
                {
                    //6♠️
                }
                if (card == 33)
                {
                    //7♠️
                }
                if (card == 34)
                {
                    //8♠️
                }
                if (card == 35)
                {
                    //9♠️
                }
                if (card == 36)
                {
                    //10♠️
                }
                if (card == 37)
                {
                    //J♠️
                }
                if (card == 38)
                {
                    //Q♠️
                }
                if (card == 39)
                {
                    //K♠️
                }
                if (card == 40)
                {
                    //A♣
                }
                if (card == 41)
                {
                    //2♣
                }
                if (card == 42)
                {
                    //3♣
                }
                if (card == 43)
                {
                    //4♣
                }
                if (card == 44)
                {
                    //5♣
                }
                if (card == 45)
                {
                    //6♣
                }
                if (card == 46)
                {
                    //7♣
                }
                if (card == 47)
                {
                    //8♣
                }
                if (card == 48)
                {
                    //9♣
                }
                if (card == 49)
                {
                    //10♣
                }
                if (card == 50)
                {
                    //J♣
                }
                if (card == 51)
                {
                    //Q♣
                }
                if (card == 21)
                {
                    //K♣
                }
            }
            return card;
        }
    }
}
