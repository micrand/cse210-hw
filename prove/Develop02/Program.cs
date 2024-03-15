using System;

class Program
{
    
    static void Main(string[] args)
    {
        PromptGenerator prompts = new PromptGenerator();
        prompts.GetRandomPrompt();

        Journal journal = new Journal();
        journal.Display();
        journal.DisplayAll();

        Entry entry = new Entry();
        entry.Display();
    }
}