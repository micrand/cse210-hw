using System.ComponentModel;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void Run()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        GetReady();

        while( DateTime.Now < futureTime )
        {   
            Console.Write("Breath in...");            
            ShowCountDown(5);
            
            Console.Write("Breath out...");
            ShowCountDown(5);

            Thread.Sleep(1000);

            Console.WriteLine();
            Console.WriteLine();
                        
        }

        DisplayEndingMessage();
       
    }
}