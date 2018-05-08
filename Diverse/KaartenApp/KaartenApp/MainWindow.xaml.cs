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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KaartenApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int counter = 0;
        CardDeck deck = new CardDeck();
        BitmapImage card;

        public MainWindow()
        {
            InitializeComponent();

           

            //MessageBox.Show(Convert.ToString(deck.Deck.Count));

            //for(int i = 0; i < deck.Deck.Count; i++)
            //{
            //    MessageBox.Show(deck.Deck[i].ToString());
            //}

            card = new BitmapImage();
            card.BeginInit();
            card.UriSource = new Uri(@"\Resources\" + "AceSpades" + ".png", UriKind.RelativeOrAbsolute);
            card.EndInit();

            lol.Background = new SolidColorBrush(Colors.LightGray);

            imageLol.Source = card;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(counter %2 == 0)
            {
                imageLol.Source = card;
            } else
            {
                imageLol.Source = null;
            }

            counter++;
            

        }
    }
}
