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

namespace Voetbal
{
    /// <summary>
    /// Interaction logic for WedstrijdWindow.xaml
    /// </summary>
    public partial class WedstrijdWindow : Window
    {
        private Speeldag speeldag;
        private int wedstrijd;

        public WedstrijdWindow(Speeldag huidigespeeldag, int index)
        {
            InitializeComponent();

            this.speeldag = huidigespeeldag;
            this.wedstrijd = index;

            ploeg1Label.Content = speeldag.PloegenReeks1[wedstrijd];
            ploeg2Label.Content = speeldag.PloegenReeks2[wedstrijd];

            spelersPloeg1ListBox.ItemsSource = speeldag.PloegenReeks1[wedstrijd].Spelers;
            spelersPloeg2ListBox.ItemsSource = speeldag.PloegenReeks2[wedstrijd].Spelers;

            spelersPloeg1ListBox.MouseDoubleClick += SpelersPloeg1ListBox_MouseDoubleClick;
            spelersPloeg2ListBox.MouseDoubleClick += SpelersPloeg2ListBox_MouseDoubleClick;

            UpdateScore();
        }

        private void SpelersPloeg2ListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            speeldag.ScoreReeks2[wedstrijd]++;
            UpdateScore();
        }

        private void SpelersPloeg1ListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            speeldag.ScoreReeks1[wedstrijd]++;
            UpdateScore();
        }

        private void UpdateScore()
        {

            scoreP1Label.Content = Convert.ToString(speeldag.ScoreReeks1[wedstrijd]);
            scoreP2Label.Content = Convert.ToString(speeldag.ScoreReeks2[wedstrijd]);
        }

        private void stopButton_Click(object sender, RoutedEventArgs e)
        {
            if(speeldag.ScoreReeks1[wedstrijd] > speeldag.ScoreReeks2[wedstrijd])
            {
                speeldag.PloegenReeks1[wedstrijd].Punten += 3;
            } else if (speeldag.ScoreReeks1[wedstrijd] == speeldag.ScoreReeks2[wedstrijd])
            {
                speeldag.PloegenReeks1[wedstrijd].Punten += 1;
                speeldag.PloegenReeks2[wedstrijd].Punten += 1;
            }else
            {
                speeldag.PloegenReeks2[wedstrijd].Punten += 3;
            }

            this.Close();
        }
    }
}
