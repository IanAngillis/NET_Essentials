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

namespace predator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Lieveheersbeestje[] predators = new Lieveheersbeestje[20];
        Luis[] preys = new Luis[100];
        Random rand = new Random();

        public MainWindow()
        {
            InitializeComponent();

            InitiatePredatorList();

            InitiatePreyList();
        }

        private void InitiatePredatorList()
        {

            for(int i = 0; i < predators.Length; i++)
            {
                predators[i] = new Lieveheersbeestje(rand.Next(16), rand.Next(16));
            }

        }

        private void InitiatePreyList()
        {

            for (int i = 0; i < preys.Length; i++)
            {
                preys[i] = new Luis(rand.Next(16), rand.Next(16));
            }

        }

        private void nextRoundButton_Button_Click(object sender, RoutedEventArgs e)
        {
            Move();

            HuntAndDeleteCapturedPrey();

            
        }

        private void HuntAndDeleteCapturedPrey()
        {
            Luis[] preysToDelete;

            foreach(Lieveheersbeestje predator in predators)
            {
                preysToDelete = predator.Chase(preys);
                predator.Eat(preysToDelete);
                DeleteCapturedPrey(preysToDelete);



            }
        }

        private void DeleteCapturedPrey(Luis [] list)
        {
           for(Luis caughtPrey in list)
            {

                foreach(Luis prey in preys)
                {
                    if(caughtPrey == prey)
                    {
                        prey = null;
                    }
                }
            }
        }



        private void Move()
        {
            MovePredators(predators);
            MovePreys(preys);
        }

        private void MovePreys(Luis[] list)
        {
            int choice;

            for (int i = 0; i < list.Length; i++)
            {

                choice = rand.Next(4);

                switch (choice)
                {
                    case 0:
                        list[i].MoveForward();
                        break;
                    case 1:
                        list[i].MoveBack();
                        break;
                    case 2:
                        list[i].MoveLeft();
                        break;
                    case 3:
                        list[i].MoveRight();
                        break;
                    default:
                        break;
                }
            }

        }

        private void MovePredators(Lieveheersbeestje [] list)
        {
            int choice;

            for(int i = 0; i < list.Length; i++)
            {

                choice = rand.Next(4);

                switch (choice)
                {
                    case 0:
                        list[i].MoveForward();
                        break;
                    case 1:
                        list[i].MoveBack();
                        break;
                    case 2:
                        list[i].MoveLeft();
                        break;
                    case 3:
                        list[i].MoveRight();
                        break;
                    default:
                        break;
                }
            }

        }
    }
}
