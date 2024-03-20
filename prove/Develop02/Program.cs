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
        // Entry entry = new Entry();
        // journal.Display();
        // journal.DisplayAll();        
        // entry.Display();       
        
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

                Entry entry = new Entry(_currentPrompt, todoText);
                entry._entryText = todoText;
                entry._promptText = _currentPrompt;
                journal.AddEntry(entry);

                journal.DisplayAll();
                
                
            }
            else if( exit_prompt == "2")
            {
               
            }
            else if(exit_prompt=="3")
            {
                
            }
            else if(exit_prompt=="4")
            {

                Console.Write("Write is the filename? ");
                string fileName = Console.ReadLine();
                
                journal.SaveToFile(fileName);
            }
        }
    }
}