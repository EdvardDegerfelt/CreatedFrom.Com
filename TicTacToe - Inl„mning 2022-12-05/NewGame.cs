using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tictac
{
    public class NewGame : IGame
    {
        protected string p1char = "X";
        protected string p2char = "O";
        protected string[] newgameboard = { "0", "1", "2", "3", "A", "", "", "", "B", "", "", "", "C", "", "", "" };

        public NewGame()
        {
            Start();
        }

            public NewGame(int i, int j)
        {
           WelcomeAndGameRules();
        }

        public NewGame(int i){}

        public void WelcomeAndGameRules()
        {
            Console.WriteLine("Hello and welcome to the game of TicTacToe!\nHere are the game rules:\n1. The game is played on a board that is 3 by 3 squares.\n2. Each player places either an \"X\" or an \"O\", on 1 of the 9 possible locations.\n3. The game is won by getting 3 marks in a row, either horizontally, vertically or diagonally.\n4. If no player wins, the game ends in a tie.\n5. You put in your \"X\" or \"O\" by typing the game board coordinates, ex. A1.\nPress any key to continue!");
            Console.ReadKey(false);
            Console.Clear();
        }
        public void Start()
        {
            Console.WriteLine("Do you want to read the rules? Press the Y-key to read the rules otherwise press the N-Key!");
            NewGame game;
            ConsoleKeyInfo input = Console.ReadKey();
            if (input.Key == ConsoleKey.Y)
            {
                Console.Clear();
                game = new NewGame(1, 1);
            }
            else if (input.Key == ConsoleKey.N)
            {
                Console.Clear();
                game = new NewGame(1);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Please chose Y or N: ");
                Start();
            }
        }
    }
}
