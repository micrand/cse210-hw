using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);

        DisplayResult( userName, squaredNumber );

    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        string favoriteNumber = Console.ReadLine();
        int favoriteNumberInt = int.Parse(favoriteNumber);
        
        return favoriteNumberInt;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;        
        return square;
    }

    static void DisplayResult(string name, int squared)
    {
        Console.WriteLine($"Your name is {name}, the square of your number is {squared}");
    }
}