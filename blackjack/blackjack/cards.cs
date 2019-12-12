using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{
    class Card
    {
        public int value;
        public string fileName;
        
        public Card(int val, string file)
        {
            value = val;
            fileName = file;
        }

        static public Card makerandomcard()
        {
            Card result = null;

            List<int> cards = new List<int>();
            Random rnd = new Random();
            int card = rnd.Next(1, 52);
            for (int i = 0; i < 10; i++)
            {
                cards.Add(card);
                card = rnd.Next(1, 52);
                if(card == 1)
                {
                    //A❤
                    result = new Card(1, "a-h.png");

                }
                if (card == 2)
                {
                    //2❤
                    result = new Card(2, "2-h.png");
                }
                if (card == 3)
                {
                    //3❤
                    result = new Card(3, "3-h.png");
                }
                if (card == 4)
                {
                    //4❤
                    result = new Card(4, "4-h.png");
                }
                if (card == 5)
                {
                    //5❤
                    result = new Card(5, "5-h.png");
                }
                if (card == 6)
                {
                    //6❤
                    result = new Card(6, "6-h.png");
                }
                if (card == 7)
                {
                    //7❤
                    result = new Card(7, "7-h.png");
                }
                if (card == 8)
                {
                    //8❤
                    result = new Card(8, "8-h.png");
                }
                if (card == 9)
                {
                    //9❤
                    result = new Card(9, "9-h.png");
                }
                if (card == 10)
                {
                    //10❤
                    result = new Card(10, "10-h.png");
                }
                if (card == 11)
                {
                    //J❤
                    result = new Card(10, "j-h.png");
                }
                if (card == 12)
                {
                    //Q❤
                    result = new Card(10, "q-h.png");
                }
                if (card == 13)
                {
                    //K❤
                    result = new Card(10, "k-h.png");
                }
                if (card == 14)
                {
                    //A◆
                    result = new Card(1, "a-d.png");
                }
                if (card == 15)
                {
                    //2◆
                    result = new Card(2, "2-d.png");
                }
                if (card == 16)
                {
                    //3◆
                    result = new Card(3, "3-d.png");
                }
                if (card == 17)
                {
                    //4◆
                    result = new Card(4, "4-d.png");
                }
                if (card == 18)
                {
                    //5◆
                    result = new Card(5, "5-d.png");
                }
                if (card == 19)
                {
                    //6◆
                    result = new Card(6, "6-d.png");
                }
                if (card == 20)
                {
                    //7◆
                    result = new Card(7, "7-d.png");
                }
                if (card == 21)
                {
                    //8◆
                    result = new Card(8, "8-d.png");
                }
                if (card == 22)
                {
                    //9◆
                    result = new Card(9, "9-d.png");
                }
                if (card == 23)
                {
                    //10◆
                    result = new Card(10, "10-d.png");
                }
                if (card == 24)
                {
                    //J◆
                    result = new Card(10, "j-d.png");
                }
                if (card == 25)
                {
                    //Q◆
                    result = new Card(10, "q-d.png");
                }
                if (card == 26)
                {
                    //K◆
                    result = new Card(10, "k-d.png");
                }
                if (card == 27)
                {
                    //A♠️
                    result = new Card(1, "a-s.png");
                }
                if (card == 28)
                {
                    //2♠️
                    result = new Card(2, "2-s.png");
                }
                if (card == 29)
                {
                    //3♠️
                    result = new Card(3, "3-s.png");
                }
                if (card == 30)
                {
                    //4♠️
                    result = new Card(4, "4-s.png");
                }
                if (card == 31)
                {
                    //5♠️
                    result = new Card(5, "5-s.png");
                }
                if (card == 32)
                {
                    //6♠️
                    result = new Card(6, "6-s.png");
                }
                if (card == 33)
                {
                    //7♠️
                    result = new Card(7, "7-s.png");
                }
                if (card == 34)
                {
                    //8♠️
                    result = new Card(8, "8-s.png");
                }
                if (card == 35)
                {
                    //9♠️
                    result = new Card(9, "a-9.png");
                }
                if (card == 36)
                {
                    //10♠️
                    result = new Card(10, "10-s.png");
                }
                if (card == 37)
                {
                    //J♠️
                    result = new Card(10, "j-s.png");
                }
                if (card == 38)
                {
                    //Q♠️
                    result = new Card(10, "q-s.png");
                }
                if (card == 39)
                {
                    //K♠️
                    result = new Card(10, "k-s.png");
                }
                if (card == 40)
                {
                    //A♣
                    result = new Card(1, "a-c.png");
                }
                if (card == 41)
                {
                    //2♣
                    result = new Card(2, "2-c.png");
                }
                if (card == 42)
                {
                    //3♣
                    result = new Card(3, "3-c.png");
                }
                if (card == 43)
                {
                    //4♣
                    result = new Card(4, "4-c.png");
                }
                if (card == 44)
                {
                    //5♣
                    result = new Card(5, "5-c.png");
                }
                if (card == 45)
                {
                    //6♣
                    result = new Card(6, "6-c.png");
                }
                if (card == 46)
                {
                    //7♣
                    result = new Card(7, "7-c.png");
                }
                if (card == 47)
                {
                    //8♣
                    result = new Card(8, "8-c.png");
                }
                if (card == 48)
                {
                    //9♣
                    result = new Card(9, "9-c.png");
                }
                if (card == 49)
                {
                    //10♣
                    result = new Card(1, "10-c.png");
                }
                if (card == 50)
                {
                    //J♣
                    result = new Card(10, "j-c.png");
                }
                if (card == 51)
                {
                    //Q♣
                    result = new Card(10, "q-c.png");
                }
                if (card == 52)
                {
                    //K♣
                    result = new Card(10, "k-c.png");
                }
            }
            return result;
        }
    }
}
