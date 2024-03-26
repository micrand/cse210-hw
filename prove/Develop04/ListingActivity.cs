public class ListingActivity : Activity 
{
    private int _count;
    private List<string> _prompts = new List<string>();
    public ListingActivity( string name, string description, int duration ) : base(name, description, duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void Run()
    {
        Console.Clear();

        GetReady();            

        Console.WriteLine("List as many responses you can to the following prompt:");

        var prompt = GetRandomPrompt();
        Console.WriteLine($"---{prompt}---:");

        Console.Write("You may begin in: ");
        ShowCountDown(3);

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);


        while(DateTime.Now < futureTime ) {
            Console.Write("");
            string input = Console.ReadLine();            
            if(input != "")
            {
                _count++;
            }
        }


        Console.WriteLine($"You listed {_count} items!");
        Console.WriteLine("");
        ShowSpinner(1);
        DisplayEndingMessage();
        

    }

    public string GetRandomPrompt()
    {
        _prompts.Add("When have you felt the Holy Ghost this month?");
        Random random = new Random();
        int index = random.Next(0, _prompts.Count);
        return _prompts[index];

    }

    public string GetListFromUser()
    {
        return "";

    }
}