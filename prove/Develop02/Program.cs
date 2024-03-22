/*
 * Purpose: Journal W02
 * Author: Randriamihaja Mickael
 * Creativities: Add additional data to the file (topic), create csv file
 *
*/
using System;
using System.IO.Enumeration;

class Program
{   
    public const string spaceOne = " ";
    
    static void Main(string[] args)
    {
        string exit_prompt = "";
        
        Console.WriteLine("Welcome to the Journal Program! ");
        Console.WriteLine("Please select one of the following choices:");

        Journal journal = new Journal();
        
        while(exit_prompt!="5")
        {
                  
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");           
            exit_prompt = Console.ReadLine();            

            

            if( exit_prompt == "1" )
            {  
                
                Console.WriteLine("What would you like to do?");
                PromptGenerator prompts = new PromptGenerator();            
                string _currentPrompt = prompts.GetRandomPrompt();
                Console.Write(_currentPrompt + spaceOne);
                string todoText = Console.ReadLine();

                Console.WriteLine("Enter the topic: ");
                string topic = Console.ReadLine();

                Entry entry = new Entry(_currentPrompt, todoText, topic);
                journal.AddEntry(entry);          
             
                
            }
            else if( exit_prompt == "2")
            {
               string aaa = journal.DisplayAll();
               Console.WriteLine(aaa);
            }
            else if(exit_prompt=="3")
            {
                Console.Write("What is the filename to load? ");
                string fileName = Console.ReadLine();
                journal.LoadFromFile(fileName);
            }
            else if(exit_prompt=="4")
            {

                Console.Write("What is the filename? ");
                string fileName = Console.ReadLine();
                
                journal.SaveToFile(fileName);
            }
        }
    }
}