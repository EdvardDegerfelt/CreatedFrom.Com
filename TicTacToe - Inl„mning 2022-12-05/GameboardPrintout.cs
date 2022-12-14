using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tictac
{
    public abstract class GameboardPrintout : PlayerMove
    {
        protected void PrintGameboard()
        {
            for (int i = 0; i < base.gameboard.Length; i++)
            {
                if (i == 4 || i == 8 || i == 12)
                    Console.WriteLine();
                if (base.gameboard[i] == "0")
                    Console.Write(" ");
                if (base.gameboard[i] == "A" || base.gameboard[i] == "B" || base.gameboard[i] == "C")
                    Console.Write(base.gameboard[i]);
                if (base.gameboard[i] == "1" || base.gameboard[i] == "2" || base.gameboard[i] == "3")
                    Console.Write($" {base.gameboard[i]} ");
                if (base.gameboard[i] == "")
                    Console.Write("( )");
                if (base.gameboard[i] == "X" || base.gameboard[i] == "O")
                {
                    Console.Write($"({Colour(base.gameboard[i])})");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            Console.WriteLine();
        }

        protected virtual string Colour(string input)
        {
            if (input == "X")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                return input;
            }
            else 
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                return input;
            }
        }
    }
}
