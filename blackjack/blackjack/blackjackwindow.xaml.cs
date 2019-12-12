using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace blackjack
{
    /// <summary>
    /// Interaction logic for blackjackwindow.xaml
    /// </summary>
    public partial class blackjackwindow : Window
    {
        public string moneys;
        public double bet = 0;
        public double blackjackbet = 0;
        public double money = 1000;
        public blackjackwindow()
        {
            InitializeComponent();
        }
        private void minbet_Click(object sender, RoutedEventArgs e, double money, int bet, double blackjackbet)
            {
                if (money >= 1)
                {
                    bet = 1;
                    blackjackbet = 1.5;
                }
                else if(money == 0)
                {
                    winlose.Visibility = Visibility.Visible;
                    winlose.Content = "You cant bet any more because you are out of moneys";
                    this.Close();
                }
            }

            private void maxbet_Click(object sender, RoutedEventArgs e, double money, double bet, double blackjackbet)
            {
                if (money >= 1)
                {
                    bet = money;
                    blackjackbet = money * 1.5;
                }
                else if(money == 0)
                {
                    winlose.Visibility = Visibility.Visible;
                    winlose.Content = "You cant bet any more because you are out of moneys";
                    this.Close();
                }
            }

        public void setCardImage(int cardNumber)
        {

            BitmapImage card = new BitmapImage();
            card.BeginInit();
            card.UriSource = new Uri(@"/images/a-c.png", UriKind.RelativeOrAbsolute);
            card.EndInit();
            Card.Source = card;
        }

        private void start_Click(object sender, RoutedEventArgs e, double money)
        {
            setCardImage(1);
            List<Card> cards = new List<Card>();
            if(money == 0)
            {
                this.Close();
            }
        }
        public int points(int acevalue1, double money, double bet, int cards, double blackjackbet)
        {
            int val = 0;
            int playerpoints = 0;
            int aipoints = 0;
            foreach (Card c in cards)
            {
                if (val == 1)
                {
                    playerpoints = acevalue1 + playerpoints;
                }
                playerpoints = playerpoints + c.value;
                if (playerpoints == 21)
                {
                    winlose.Visibility = Visibility.Visible;
                    winlose.Content = "win";
                    money = money + bet;
                }
                else if(playerpoints == 21 & cards == 2)
                {
                    winlose.Visibility = Visibility.Visible;
                    winlose.Content = "BLACKJACK!!!";
                    money = money + blackjackbet;
                }
                else if (playerpoints < 21 & (aipoints < playerpoints || aipoints > 21))
                {
                    winlose.Visibility = Visibility.Visible;
                    winlose.Content = "win";
                    money = money + bet;
                }
                else if (playerpoints > 21)
                {
                    winlose.Visibility = Visibility.Visible;
                    winlose.Content = "lose";
                    money = money - bet;
                }
                else if (playerpoints < 21 & aipoints > playerpoints & aipoints < 21)
                {
                    winlose.Visibility = Visibility.Visible;
                    winlose.Content = "lose";
                    money = money - bet;
                }
                else if (playerpoints < 21 & aipoints == 21)
                {
                    winlose.Visibility = Visibility.Visible;
                    winlose.Content = "lose";
                    money = money - bet;
                }
                else
                {
                    winlose.Visibility = Visibility.Visible;
                    winlose.Content = "idk what u did to break this but good job";
                }
            }
            return playerpoints;
            return aipoints;
        }
    
        private void back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win = new MainWindow();
            win.Show();
            this.Close();
        }
        
        private void acevalue_TextChanged(object sender, TextChangedEventArgs e)
        {
            int acevalue1 = Convert.ToInt32(acevalue.Text);
            if(acevalue.Text == "1"){

            }
            else if(acevalue.Text == "11")
            {

            }
            else
            {
                this.Close();
            }
        }
        private void hit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void stand_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
