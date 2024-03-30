using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        const string spaceSeparator = " ";
        string scriptureText = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";
       
        Reference reference = new Reference("John",3,16);
        Scripture scripture = new Scripture(reference, scriptureText);
       

        string displayText = "";
        while( displayText != "quit" )
        {
            reference.GetDisplayText();
            scripture.GetDisplayText();            

            Console.WriteLine();
            displayText = Console.ReadLine();
            Console.Clear();
        }
    }
}