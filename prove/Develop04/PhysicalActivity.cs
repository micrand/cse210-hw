public class PhysicalActivity : Activity 
{
    private List<string> _activities = new List<string>();
    public PhysicalActivity( string name, string description, int duration ) : base( name, description, duration )
    {   


    }

    public void Run()
    {
        GetReady();

        string activity = GetListActivities();
        Console.Write("What activity would you practice now: ");
        ShowCountDown(3);
        Console.WriteLine($"---{activity}---");
        ShowSpinner(3);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        ShowSpinner(3);
        Console.WriteLine("Let's go...");

        int j = 0;

        while( DateTime.Now < endTime )
        {

            if(j>1){
                Console.WriteLine("Again!");
                ShowSpinner(1);
            }

            ShowCountDown(5);
            
            for(var i=0;i<10;i++){
                Console.Write(".");
                Thread.Sleep(1000);
            }
            
            j++;
        }

        Console.WriteLine("Yess!!!! Congrats...");

        DisplayEndingMessage();
    }

    public string GetListActivities()
    {
        _activities.Add("Burpees");
        _activities.Add("Squat");
        _activities.Add("Dancing");
        _activities.Add("Yoga");
        Random random = new Random();
        int index = random.Next(0, _activities.Count);

        return _activities[index];

    }
}