using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        const string spaceSeparator = " ";
        string scriptureText = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";
        // Word word = new Word(text);
        Reference reference = new Reference("John",3,3);
        Scripture scripture = new Scripture(reference, scriptureText);
        string word = "";

        string displayText = "";
        while( displayText != "quit" )
        {
            int nbText = scriptureText.Split(spaceSeparator).Count();
            // var i = 0;
            foreach(var data in scriptureText.Split(spaceSeparator))
            {
                Word displayWord = new Word(data);                
                word = displayWord.GetDisplayText()+spaceSeparator;
                Console.Write(word);
            }
            Console.WriteLine();
            displayText = Console.ReadLine();
            Console.Clear();
        }

        // Console.WriteLine(GetDisplayText());
    }
}