using System.Diagnostics;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();
    public ReflectingActivity( string name, string description, int duration ) : base(name, description, duration)
    {
        _name = name;
        _description = description;
        _duration = duration;

    }

    public void Run()
    {
        GetReady();
        DisplayPrompt();
        var randomQuestion = GetRandomQuestion();
        Console.Write(randomQuestion);
        ShowSpinner(3);
        Console.WriteLine("");
        Console.Write(randomQuestion);
        Console.WriteLine("");
        DisplayEndingMessage();

    }

    public string GetRandomPrompt()
    {
        return "";
    }

    public string GetRandomQuestion()
    {
        _questions.Add("How did you feel when it was complete? ");
        _questions.Add("What is your favorite thing about this experience? ");
        // _questions.Add("");
        // _questions.Add("");
        // _questions.Add("");
        // _questions.Add("");
        Random random = new Random();
        int index = random.Next(0, _questions.Count);
        return _questions[index];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("---Think of a time when you did something really difficult.---");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");        
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(3);
        Console.Clear();

    }

    public void DisplayQuestions()
    {
        
    }
}