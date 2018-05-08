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

namespace animals
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Animal anim1, anim2, anim3;
          //anim1 = new Animal("Woefie");
            anim2 = new Dog("Pluto");
            anim3 = new SmallDog("Fifie");

            //PrintAnimal(anim1);
            PrintAnimal(anim2);
            PrintAnimal(anim3);

        }

        private void PrintAnimal(Animal anim)
        {
            MessageBox.Show(anim.ToString());
        }
    }
}
