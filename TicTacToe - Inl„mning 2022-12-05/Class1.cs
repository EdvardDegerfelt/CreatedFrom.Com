using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Tictac;
namespace Tictac;

public class Player
{
    private string name;
    public string Name { get => name; private set => name = value; }
    public int AmountOfWins { get; private set; }
    public int AmountOfTies { get; private set; }

    public Player()
    {
        this.Name = PlayerName();
        
    }
    static string PlayerName()
    {
        string name;
        Console.WriteLine("Enter your name: ");
        name = Console.ReadLine() ?? "";
        try
        {
            CheckNameForError(name);
        }
        catch (Exception error)
        {
            if (error.Message == "Null")
            {
                return PlayerName("ERROR: Name must be atleast 1 character long. Please try again!");
            }
            if (error.Message == "Length Override")
            {
                return PlayerName("ERROR: Name can not contain more than 15 letters. Please try again!");
            }
            if (error.Message == "Number")
            {
                return PlayerName("ERROR: Name can not contain any numbers. Please try again!");
            }
        }
        return name;
    }
    static string PlayerName(string error)
    {
        Console.WriteLine(error);
        return PlayerName();
    }

    static string CheckNameForError(string name)
    {
        if (name.Any(char.IsDigit))
        {
            throw new Exception("Number");
        }
        if (name.Length > 15)
        {
            throw new Exception("Length Override");
        }
        if (name == null || name.Length == 0)
        {
            throw new Exception("Null");
        }
        return name;
    }


    public void AddWin()
    {
        this.AmountOfWins++;
    }

    public void AddTie()
    {
        this.AmountOfTies++;
    }
}
