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
    /// Interaction logic for RangschikkingWindow.xaml
    /// </summary>
    public partial class RangschikkingWindow : Window
    {
        private List<Ploeg> rankingList = new List<Ploeg>();
        private Window mainWindow;

        public RangschikkingWindow(List<Ploeg> ploegen, Window otherwindow)
        {
            mainWindow = otherwindow;
            mainWindow.Hide();
            InitializeComponent();
            CopyList(ploegen);
            UpdateRanking();
            WriteRanking();
        }

        private void WriteRanking()
        {
            rangschikkingTextBox.Text = "";

            for (int i = 0; i < rankingList.Count; i++)
            {
                rangschikkingTextBox.Text += rankingList[i].Punten + "\t" + rankingList[i].Naam + "\n";
            }
        }

        private void UpdateRanking()
        {

            for (int i = 0; i < rankingList.Count; i++)
            {

                for (int j = i; j < rankingList.Count; j++)
                {

                    if (rankingList[j].Punten > rankingList[i].Punten)
                    {
                        Ploeg temp = rankingList[i];
                        rankingList[i] = rankingList[j];
                        rankingList[j] = temp;
                    }
                }
            }
        }

        private void CopyList(List<Ploeg> ploegen)
        {
            for (int i = 0; i < ploegen.Count; i++)
            {
                rankingList.Add(ploegen[i]);
            }
        }

        private void sluitButton_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.Show();
            this.Close();
        }
    }
}

