using System;
using System.Collections.Generic;
public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;

    }

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;

    }

    public void GetReady()
    {
        Console.WriteLine("Get Ready...");
        
        ShowSpinner(1);
        Console.WriteLine();
        Console.WriteLine();
        
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
    }

    public void DisplayEndingMessage()
    {
        Console.Write("Well Done!");
        Console.WriteLine();
        ShowSpinner(3);
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine($"You have completed another {_duration} seconds of {_name}.");
        ShowSpinner(2);
        Console.WriteLine();
        Console.WriteLine();
        Console.Clear();

    }

    public void ShowSpinner(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);

        while( DateTime.Now < futureTime ) 
        {
            List<string> spinnerStrings = new List<string>();
            spinnerStrings.Add("|");
            spinnerStrings.Add("/");
            spinnerStrings.Add("-");
            spinnerStrings.Add("\\");
            spinnerStrings.Add("|");
            spinnerStrings.Add("/");
            spinnerStrings.Add("-");
            spinnerStrings.Add("\\");
            foreach(string spin in spinnerStrings)
            {
                Console.Write(spin);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
        
    }

    public void ShowCountDown(int seconds)
    {
        for(var i = 5;i>0;i--) 
        {                
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");        
        }
        Console.WriteLine();
        
    }


}