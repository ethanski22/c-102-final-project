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
        public blackjackwindow()
        {
            InitializeComponent();
        }

        public void setCardImage(int cardNumber)
        {

            BitmapImage card = new BitmapImage();
            card.BeginInit();
            card.UriSource = new Uri(@"/images/a-c.png", UriKind.RelativeOrAbsolute);
            card.EndInit();
            Card.Source = card;
        }

        private void start_Click(object sender, RoutedEventArgs e)
        {
            setCardImage(1);
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win = new MainWindow();
            win.Show();
            this.Close();
        }

        private void minbet_Click(object sender, RoutedEventArgs e)
        {

        }

        private void maxbet_Click(object sender, RoutedEventArgs e)
        {

        }

        private void acevalue_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(acevalue == 1){

            }
            else if(acevalue == 11)
            {

            }
            else
            {
                this.Close();
            }
            int acevalue1 = acevalue.Text;
        }
    }
}
