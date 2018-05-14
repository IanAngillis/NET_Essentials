using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace domineering
{
    public class Board
    {
        private Block[,] gameBoard;
        public movewWindow MovesWindow { get; set; }
        public int BoardSize { get; set; }
        private int turns = 1;
        public int CurrentPlayer { get; set; }
        public bool GameHasWinner { get; set; }

        public Board(int boardSize, Canvas canvas)
        {
            BoardSize = boardSize;
            CurrentPlayer = GetCurrentPlayer();
            CreateGameBoard(BoardSize, canvas);
        }

        public void DisplayMoves()
        {
            MovesWindow = new movewWindow();
            MovesWindow.Show();
        }

        public void Reset()
        {
            ResetProperties();
            ResetBoard();
            ResetMoves();
            ResetWindow();
        }

        private void ResetWindow()
        {
            MovesWindow = null;
        }

        private void ResetMoves()
        {
            File.WriteAllText("moves.txt", String.Empty);
        }

        private void ResetBoard()
        {
            foreach (Block block in gameBoard)
            {
                block.BlockArea.Fill = new SolidColorBrush(Colors.White);
                block.IsFilled = false;
            }
        }

        private void ResetProperties()
        {
            turns = 1;
            CurrentPlayer = GetCurrentPlayer();
            GameHasWinner = false;
        }

        public int GetCurrentPlayer()
        {
            if (turns % 2 == 0)
            {
                return 2;
            }
            else
            {
                return 1;
            }
        }

        private void CreateGameBoard(int boardSize, Canvas canvas)
        {
            gameBoard = new Block[boardSize, boardSize];

            InitGameBoard(500 / (double)boardSize, canvas);
            DisplayBoardOn(canvas);

        }

        private void DisplayBoardOn(Canvas canvas)
        {
            foreach (Block block in gameBoard)
            {
                canvas.Children.Add(block.BlockArea);
            }
        }

        public void InitGameBoard(double size, Canvas canvas)
        {

            double marginLeft = 7;
            double marginTop = 7;

            for (int row = 0; row < gameBoard.GetLength(0); row++)
            {

                marginLeft = 7;
                marginTop = (row * size) + 7;

                for (int colum = 0; colum < gameBoard.GetLength(1); colum++)
                {
                    gameBoard[row, colum] = new Block(row, colum, marginLeft, marginTop, size);
                    marginLeft += size;
                }
            }
        }

        private void ColorBlock(int row, int colum, int player)
        {
            if (player == 1)
            {
                ColorVertical(row, colum, new SolidColorBrush(Colors.Red));
            }
            else
            {
                ColorHorizontal(row, colum, new SolidColorBrush(Colors.Blue));
            }
        }

        private void ColorVertical(int row, int colum, SolidColorBrush brush)
        {
            gameBoard[row, colum].BlockArea.Fill = brush;
            gameBoard[row + 1, colum].BlockArea.Fill = brush;

            gameBoard[row, colum].IsFilled = true;
            gameBoard[row + 1, colum].IsFilled = true;
        }

        private void ColorHorizontal(int row, int colum, SolidColorBrush brush)
        {
            gameBoard[row, colum].BlockArea.Fill = brush;
            gameBoard[row, colum + 1].BlockArea.Fill = brush;

            gameBoard[row, colum].IsFilled = true;
            gameBoard[row, colum + 1].IsFilled = true;
        }

        public void Update(int row, int colum)
        {
            try
            {
                CheckIfMoveIsValid(row, colum);
                ColorBlock(row, colum, CurrentPlayer);
                WriteMoveToFile(row, colum);
                turns++;
                CurrentPlayer = GetCurrentPlayer();

                if (!IsMovePossible(CurrentPlayer))
                {
                    MessageBox.Show(string.Format("Speler {0} heeft verloren", CurrentPlayer));
                    GameHasWinner = true;
                }
            }
            catch (DomineeringException ex)
            {
                MessageBox.Show(ex.Message, "Rule violation");
            }
        }

        private void WriteMoveToFile(int row, int colum)
        {

            StreamWriter outputStream = null;

            try
            {
                outputStream = File.AppendText("moves.txt");

                if(CurrentPlayer == 1)
                {
                    outputStream.WriteLine(string.Format("Player {0} ({1} , {2}) ({3} , {4})", Convert.ToString(CurrentPlayer), Convert.ToString(row), Convert.ToString(colum), Convert.ToString(row+1), Convert.ToString(colum)));
                }
                else
                {
                    outputStream.WriteLine(string.Format("Player {0} ({1} , {2}) ({3} , {4})", Convert.ToString(CurrentPlayer), Convert.ToString(row), Convert.ToString(colum), Convert.ToString(row), Convert.ToString(colum + 1)));
                }

                outputStream.Close();
               
            }
            catch (IOException ex)
            {
                MessageBox.Show("Internal error, click ok to exit the program. All progress will be lost. Error:" + ex.Message);
                outputStream = null;
                System.Environment.Exit(1);
            }
            finally
            {
                if (outputStream != null)
                {
                    outputStream.Close();
                }
            }

        }

        private void CheckIfMoveIsValid(int row, int colum)
        {
            if (CurrentPlayer == 1)
            {
                CheckVertical(row, colum);
            }
            else
            {
                CheckHorizontal(row, colum);
            }
        }

        private void CheckVertical(int row, int colum)
        {
            if (row == (gameBoard.GetLength(0) - 1))
            {
                throw new DomineeringException("Invalid move: out of bounds");

            }
            else if (gameBoard[row + 1, colum].IsFilled)
            {
                throw new DomineeringException("Invalid move: position is already taken");
            } else if(gameBoard[row, colum].IsFilled)
            {
                throw new DomineeringException("Invalid move: position is already taken");
            }
        }

        private void CheckHorizontal(int row, int colum)
        {
            if (colum == (gameBoard.GetLength(1) - 1))
            {
                throw new DomineeringException("Invalid move: out of bounds");
            }
            else if (gameBoard[row, colum + 1].IsFilled)
            {
                throw new DomineeringException("Invalid move: position is already taken");

            } else if(gameBoard[row, colum].IsFilled)
            {
                throw new DomineeringException("Invalid move: position is already taken");
            }

        }

        private bool IsMovePossible(int player)
        {

            for (int i = 0; i < gameBoard.GetLength(0); i++)
            {
                for (int j = 0; j < gameBoard.GetLength(1); j++)
                {
                    if (MoveIsPossibleAtPosition(i, j, player))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private bool MoveIsPossibleAtPosition(int row, int colum, int player)
        {
            if (gameBoard[row, colum].IsFilled)
            {
                return false;
            }

            if (player == 1)
            {

                if (row == (gameBoard.GetLength(0) - 1))
                {
                    return false;

                }
                else if (gameBoard[row + 1, colum].IsFilled)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                if (colum == (gameBoard.GetLength(1) - 1))
                {
                    return false;

                }
                else if (gameBoard[row, colum + 1].IsFilled)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

    }
}