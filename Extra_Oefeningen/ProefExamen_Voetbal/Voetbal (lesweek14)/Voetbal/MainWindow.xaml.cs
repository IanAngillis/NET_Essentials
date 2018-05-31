using System;
using System.Collections.Generic;
using System.IO;
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

namespace Voetbal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const int spelersCount = 11;
        private List<Ploeg> ploegen;
        private List<Speeldag> speeldagen;
       
        public MainWindow()
        {
            InitializeComponent();
            InitializeMainWindow();
            ploegen = new List<Ploeg>();
            speeldagen = new List<Speeldag>();
        }

        private void InitializeMainWindow()
        {
            CompititeMenuItem.IsEnabled = false;
            IngevenScoresMenuItem.IsEnabled = false;
            RangschikMenuItem.IsEnabled = false;
            wedstrijdenListBox.MouseDoubleClick += WedstrijdenListBox_MouseDoubleClick;
            speelDagenListBox.SelectionChanged += SpeelDagenListBox_SelectionChanged;
        }

        private void WedstrijdenListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            WedstrijdWindow wedstrijdWindow = new WedstrijdWindow((Speeldag)speelDagenListBox.SelectedItem, wedstrijdenListBox.SelectedIndex);
            wedstrijdWindow.ShowDialog();
        }


        private void SpeelDagenListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            wedstrijdenListBox.Items.Clear();
            MaakWedstrijden();
        }

        private void MaakWedstrijden()
        {
            Speeldag speeldag = null;

            for (int i = 0; i < 8; i++)
            {
                ListBoxItem newItem = new ListBoxItem();
                speeldag = (Speeldag)speelDagenListBox.SelectedItem;
                newItem.Content = speeldag.PloegenReeks1[i] + " - " + speeldag.PloegenReeks2[i];
                wedstrijdenListBox.Items.Add(newItem);
            }
        }

        /*DraaiPloegen()
         * {
         *      ploegen.Insert(8, ploegen[1]);   Aantal is 17 elementen
         *      ploegen.Insert(9, ploegen[16]);  Aantal is 18 elementen
         *      ploegen.RemoveAt(1);             Aantal is 17 elementen
         *      ploegen.RemoveAt(16);            Aantal is 16 elementen
         * }
         * */

        private void DraaiPloegen()
        {
            Ploeg temp = ploegen[1];

            for(int i = 1; i < 7; i++)
            {
                ploegen[i] = ploegen[i + 1];
            }

            ploegen[7] = ploegen[15];

            for(int i = 15; i > 7; i--)
            {
                ploegen[i] = ploegen[i - 1];
            }

            ploegen[8] = temp;
        
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            SpelersEnPloegenInlezen();
        }

        private void SpelersEnPloegenInlezen()
        {
            StreamReader ploegInputStream = null;
            StreamReader spelerInputStream = null;
            string readPloegLine = "";
            string readSpelerLine = "";
            string[] ploegInfo = null;
            string[] spelersInfo = null;

            try
            {
                //ploegInputStream = File.OpenText("..\\..\\Ploegen.txt");
                //spelerInputStream = File.OpenText("..\\..\\Spelers.txt");

                ploegInputStream = new StreamReader("..\\..\\Ploegen.txt", System.Text.Encoding.Default);
                spelerInputStream = new StreamReader("..\\..\\Spelers.txt", System.Text.Encoding.Default);

                readPloegLine = ploegInputStream.ReadLine();
                readSpelerLine = spelerInputStream.ReadLine();
                
                while(readPloegLine != null)
                {
                    ploegInfo = readPloegLine.Split(',');

                    Ploeg ploeg = new Ploeg(ploegInfo[0], ploegInfo[1]);

                    for(int i = 0; i < spelersCount; i++)
                    {
                        if(readSpelerLine != null)
                        {
                            spelersInfo = readSpelerLine.Split(',');

                            if (spelersInfo[0] != ploegInfo[0])
                            {
                                MessageBox.Show("Verschillende ploeg");
                            }

                            ploeg.Spelers.Add(new Speler(spelersInfo[3], spelersInfo[2], spelersInfo[1], spelersInfo[4]));
                        }
                        else
                        {
                            break;
                        }

                        readSpelerLine = spelerInputStream.ReadLine();
                    }

                    ploegen.Add(ploeg);
                    readPloegLine = ploegInputStream.ReadLine();
                }
            }
            catch(FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("File not found");
            }
            finally
            {
                ploegInputStream.Close();
                spelerInputStream.Close();
            }

            MaakCompititieBeschikbaar();

        }

        private void MaakCompititieBeschikbaar()
        {
            CompititeMenuItem.IsEnabled = true;
            SamenstellenWedstrijdenMenuItem.IsEnabled = true;
            IngevenScoresMenuItem.IsEnabled = false;
            RangschikMenuItem.IsEnabled = false;
        }

        private void SamenstellenWedstrijdenMenuItem_Click(object sender, RoutedEventArgs e)
        {
            OpstellenSpeeldagen();
        }

        private void OpstellenSpeeldagen()
        {
            DateTime huidigeSpeeldag = getEersteSpeeldag();

            for(int i = 0; i < 15; i++)
            {
                speeldagen.Add(new Speeldag((i + 1), ploegen, huidigeSpeeldag));
                DraaiPloegen();
                huidigeSpeeldag = huidigeSpeeldag.AddDays(7);
            }

            MaakScoreEnRangschikkingMogelijk();

        }

        private DateTime getEersteSpeeldag()
        {
            DateTime day = new DateTime(DateTime.Now.Year, 7, 31);

            while(day.DayOfWeek != DayOfWeek.Saturday)
            {
                day = day.AddDays(-1);
            }

            return day;
        }

        private void MaakScoreEnRangschikkingMogelijk()
        {
            SamenstellenWedstrijdenMenuItem.IsEnabled = false;
            IngevenScoresMenuItem.IsEnabled = true;
            RangschikMenuItem.IsEnabled = true;
        }

        private void IngevenScoresMenuItem_Click(object sender, RoutedEventArgs e)
        {
            LoadItemsSpeeldagen();
            
        }

        private void LoadItemsSpeeldagen()
        {
            speelDagenListBox.ItemsSource = null;
            speelDagenListBox.ItemsSource = speeldagen;
        }

        private void RangschikMenuItem_Click(object sender, RoutedEventArgs e)
        {
            RangschikkingWindow rangSchikkingsWindow = new RangschikkingWindow(ploegen, this);
            rangSchikkingsWindow.ShowDialog();
        }
    }
}
