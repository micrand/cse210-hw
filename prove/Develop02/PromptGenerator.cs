class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public string GetRandomPrompt()
    {
        string exit_prompt = "";
        
        Console.WriteLine("Welcome to the Journal Program! ");
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");

        Console.WriteLine("Please select one of the following choices");


        Journal jObject = new Journal();
        
        
        while(exit_prompt!="5")
        {
            
            Console.WriteLine("What would you like to do?");            
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            exit_prompt = Console.ReadLine();
            
            Random rand = new Random();
            

            if( exit_prompt == "1" )
            {
                
                Console.Write(_prompts[rand.Next(0,_prompts.Count)]);
                
                Console.ReadLine();          

                Entry newEntry = new Entry();
                jObject.AddEntry(newEntry);                      
                
            }
            else if( exit_prompt == "2")
            {
                Journal jnl = new Journal();
                jnl.Display();

            }else if(exit_prompt=="3")
            {

            }
            else if(exit_prompt=="4")
            {

            }
            
            
        //      foreach(string prompt in _prompts)
        //     // {
        //     //     Console.WriteLine(prompt);
        //     // }
        }
        
        return "";       
    }
}