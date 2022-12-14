using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tictac
{
    public class PlayerMove :NewGame
    {
        protected string[] gameboard = new string[15];


        public PlayerMove()
        {
            gameboard = base.newgameboard;

        }

        protected void MoveInput(string p1)
        {
            string pinput = Console.ReadLine() ?? "";

            if (pinput.ToUpper() == "A1")
            {
                if (gameboard[5] == "X" || gameboard[5] == "O")
                {
                    Console.WriteLine("Chosen square already has a mark, please choose another square");
                    MoveInput(p1);
                }
                else
                gameboard[5] = p1;
            }
            else if (pinput.ToUpper() == "A2")
            {
                if (gameboard[6] == "X" || gameboard[6] == "O")
                {
                    Console.WriteLine("Chosen square already has a mark, please choose another square");
                    MoveInput(p1);
                }
                else
                    gameboard[6] = p1;
            }
            else if (pinput.ToUpper() == "A3")
            {
                if (gameboard[7] == "X" || gameboard[7] == "O")
                {
                    Console.WriteLine("Chosen square already has a mark, please choose another square");
                    MoveInput(p1);
                }
                else
                    gameboard[7] = p1;
            }
            else if (pinput.ToUpper() == "B1")
            {
                if (gameboard[9] == "X" || gameboard[9] == "O")
                {
                    Console.WriteLine("Chosen square already has a mark, please choose another square");
                    MoveInput(p1);
                }
                else
                    gameboard[9] = p1;
            }
            else if (pinput.ToUpper() == "B2")
            {
                if (gameboard[10] == "X" || gameboard[10] == "O")
                {
                    Console.WriteLine("Chosen square already has a mark, please choose another square");
                    MoveInput(p1);
                }
                else
                    gameboard[10] = p1;
            }
            else if (pinput.ToUpper() == "B3")
            {
                if (gameboard[11] == "X" || gameboard[11] == "O")
                {
                    Console.WriteLine("Chosen square already has a mark, please choose another square");
                    MoveInput(p1);
                }
                else
                    gameboard[11] = p1;
            }
            else if (pinput.ToUpper() == "C1")
            {
                if (gameboard[13] == "X" || gameboard[13] == "O")
                {
                    Console.WriteLine("Chosen square already has a mark, please choose another square");
                    MoveInput(p1);
                }
                else
                    gameboard[13] = p1;
            }
            else if (pinput.ToUpper() == "C2")
            {
                if (gameboard[14] == "X" || gameboard[14] == "O")
                {
                    Console.WriteLine("Chosen square already has a mark, please choose another square");
                    MoveInput(p1);
                }
                else
                    gameboard[14] = p1;
            }
            else if (pinput.ToUpper() == "C3")
            {
                if (gameboard[15] == "X" || gameboard[15] == "O")
                {
                    Console.WriteLine("Chosen square already has a mark, please choose another square");
                    MoveInput(p1);
                }
                else
                    gameboard[15] = p1;
            }
            else if (pinput.ToUpper() == "" || pinput.ToUpper() == null)
            {
                Console.WriteLine("Please input a value ex. A1:");
                MoveInput(p1);
            }
            else
            {
                Console.WriteLine("Please use correct syntax ex. A1:");
                MoveInput(p1);
            }
        }
    }
}
