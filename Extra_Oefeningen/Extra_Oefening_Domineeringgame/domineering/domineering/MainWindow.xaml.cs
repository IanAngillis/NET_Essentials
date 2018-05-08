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

namespace domineering
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Board game;

        public MainWindow()
        {
            InitializeComponent();
            InitializeLayout();

            game = new Board(8, gameBoardCanvas_Canvas);
            game.Reset();
        }

        public void InitializeLayout()
        {
            startAGameMenuItem_MenuItem.IsEnabled = true;
            MovesMenuItem_MenuItem.IsEnabled = false;
            gameBoardCanvas_Canvas.IsEnabled = false;
            positionTextblock_TextBlock.Text = "(? , ?)";
            mainWindowGrid_Grid.Background = new SolidColorBrush(Colors.LightBlue);
            gameBoardCanvas_Canvas.Background = new SolidColorBrush(Colors.White);
        }

        private void gameBoardCanvas_Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            xCoordValueTextBlock_TextBlock.Text = Convert.ToString((int)e.GetPosition(gameBoardCanvas_Canvas).X);
            yCoordValueTextBlock_TextBlock.Text = Convert.ToString((int)e.GetPosition(gameBoardCanvas_Canvas).Y);
            positionTextblock_TextBlock.Text = string.Format("({0} , {1})", CalculatePosition((int)e.GetPosition(gameBoardCanvas_Canvas).Y - 7), CalculatePosition((int)e.GetPosition(gameBoardCanvas_Canvas).X - 7)); 
        }

        public int CalculatePosition(int position)
        {
            return position / (500 / game.BoardSize);
        }

        private void StartGameMenuItem_Click(object sender, RoutedEventArgs e)
        {
            MovesMenuItem_MenuItem.IsEnabled = false;
            gameBoardCanvas_Canvas.IsEnabled = true;

            game.Reset();
            
            playerTurnLabel_Label.Content = string.Format("It's player {0}'s turn", game.CurrentPlayer);
            positionTextblock_TextBlock.Text = "(? , ?)";
            xCoordValueTextBlock_TextBlock.Text = "";
            yCoordValueTextBlock_TextBlock.Text = "";


        }

        private void MovesMenuItem_Click(object sender, RoutedEventArgs e)
        {

            game.DisplayMoves();
        }

        private void ExitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void gameBoardCanvas_Canvas_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            game.Update(CalculatePosition((int)e.GetPosition(gameBoardCanvas_Canvas).Y - 7), CalculatePosition((int)e.GetPosition(gameBoardCanvas_Canvas).X - 7));
            playerTurnLabel_Label.Content = string.Format("It's player {0}'s turn", game.CurrentPlayer);

            if (game.GameHasWinner)
            {
                MovesMenuItem_MenuItem.IsEnabled = true;
                gameBoardCanvas_Canvas.IsEnabled = false;
            }
        }
    }
}
