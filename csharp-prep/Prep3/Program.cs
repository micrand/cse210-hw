using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        
        int magicNumber;
        int userGuess;
        
        string response = "no";

        Console.Write("What is the magic number? ");
        magicNumber = int.Parse(Console.ReadLine());

        do 
        {
           
            Console.Write("What is your guess? ");
            userGuess = int.Parse(Console.ReadLine());

            string resultText="";

            if(magicNumber < userGuess )
            {
                resultText = "Lower";
                response = "yes";
            }
            else if( magicNumber > userGuess)
            {
                resultText = "Higher";
                response = "yes";
            }else {
                resultText = "Bingo";
                response = "no";

            }

            Console.WriteLine($"{resultText}");
           
        }
        while( response == "yes");
    }
}