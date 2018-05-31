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

namespace Oefening_13_8
{
    /// <summary>
    /// Interaction logic for DetailWindow.xaml
    /// </summary>
    public partial class DetailWindow : Window
    {
        public DetailWindow(Persoon persoon)
        {
            InitializeComponent();

            this.Title = "Details: " + persoon.Naam + " " + persoon.Voornaam;
            this.NameTextBlock_TextBlock.Text = persoon.Naam;
            this.FirstNameTextBlock_TextBlock.Text = persoon.Voornaam;
            this.GenderTextblock_TextBlock.Text = Convert.ToString(persoon.Geslact);
            this.AdresTextBlock_TextBlock.Text = persoon.Adres;
            this.PhoneNumberTextBlock_TextBlock.Text = persoon.Telefoon;
            this.BirthdayTextBlock_TextBlock.Text = persoon.GeboorteDatum;

        }
    }
}
