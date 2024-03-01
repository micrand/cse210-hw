using System;

class Program
{
    static void Main(string[] args)
    {        
        //ask a user their first name
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        // ask  
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        
        Console.WriteLine($"Your name is {name}, {firstName} {name}");
    }
}