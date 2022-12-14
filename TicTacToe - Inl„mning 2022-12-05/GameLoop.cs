using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tictac
{
    public class GameLoop : GameboardPrintout//ärva från Player så att man kan få tie++ och win++
    {
        private bool wcheck = false;

        public GameLoop()
        {
            Start();
        }

        public void Start()
        { 
            Player player1 = new Player();
            Player player2 = new Player();
            int Turncounter = 1;
            base.PrintGameboard();
            do
            {
                string Print;
                string currentPlayer;
                string PlayerSymbol;
                if (Turncounter % 2 != 0)
                {
                    Print = p1char;
                    PlayerSymbol = Print;
                    currentPlayer = player1.Name;
                }
                else
                {
                    Print = p2char;
                    PlayerSymbol = Print;
                    currentPlayer = player2.Name;
                }

                Console.Write($"{currentPlayer} choose a space: ");
                base.MoveInput(Print);
                base.PrintGameboard();

                if (base.gameboard[5] == PlayerSymbol && base.gameboard[6] == PlayerSymbol && base.gameboard[7] == PlayerSymbol ||
                    base.gameboard[9] == PlayerSymbol && base.gameboard[10] == PlayerSymbol && base.gameboard[11] == PlayerSymbol ||
                    base.gameboard[13] == PlayerSymbol && base.gameboard[14] == PlayerSymbol && base.gameboard[15] == PlayerSymbol ||
                    base.gameboard[5] == PlayerSymbol && base.gameboard[9] == PlayerSymbol && base.gameboard[13] == PlayerSymbol ||
                    base.gameboard[6] == PlayerSymbol && base.gameboard[10] == PlayerSymbol && base.gameboard[14] == PlayerSymbol ||
                    base.gameboard[7] == PlayerSymbol && base.gameboard[11] == PlayerSymbol && base.gameboard[15] == PlayerSymbol ||
                    base.gameboard[5] == PlayerSymbol && base.gameboard[10] == PlayerSymbol && base.gameboard[15] == PlayerSymbol ||
                    base.gameboard[7] == PlayerSymbol && base.gameboard[10] == PlayerSymbol && base.gameboard[13] == PlayerSymbol)
                {
                    wcheck = true;
                    base.PrintGameboard();
                    Console.WriteLine($"{currentPlayer} wins");
                }

                else if (ArrayFull(base.gameboard) == true)
                {
                    Console.WriteLine("It's a tie!");
                    wcheck = true;
                }

                else
                Turncounter++;
            }
            while (wcheck == false);
        }

        private bool ArrayFull(string[] arrtest)
        {
            bool arrcheck = false;
            for (int i = 0; i < base.gameboard.Length; i++)
            {
                if (base.gameboard[i] == "")
                {
                    arrcheck = false;
                    break;
                }
                else
                    arrcheck = true;
            }
            return arrcheck;
        }

        protected override string Colour(string input)
        {
            if (wcheck)
                Console.ForegroundColor = ConsoleColor.Green;
            else
                base.Colour(input);
            return input;
        }
    }
}